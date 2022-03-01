using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using vpmc_backend.Models;
using Microsoft.AspNetCore.Identity;
using vpmc_backend.ViewModel;
using Microsoft.AspNetCore.Authorization;
using vpmc_backend.Areas.Identity.Data;


namespace vpmc_backend.Controllers
{
    public class ParkController : Controller
    {
        public static IWebHostEnvironment _environment;
        private readonly WebApiContext _context;
        private string _parkSDS_path;
        private readonly UserManager<vpmc_backendUser> _userManager;
        private readonly SignInManager<vpmc_backendUser> _signInManager;
        private string _fileErrorResponse;

        public ParkController(WebApiContext context, IWebHostEnvironment environment, UserManager<vpmc_backendUser> userManager, SignInManager<vpmc_backendUser> signInManager)
        {
            _context = context;
            _environment = environment;
            _parkSDS_path = _environment.WebRootPath + "\\Upload\\ParkSurveyDataSheets\\";
            _userManager = userManager;
            _signInManager = signInManager;
        }


        private bool _fileChecking(ParkSurveySheetForm model)
        {
            // 檢查檔案是否上傳
            if (model.TranscriptFile == null)
            {
                _fileErrorResponse = "Missing Transcriptfile!";
                return false;
            }
            if (model.SurveyPhoto == null)
            {
                _fileErrorResponse = "Missing Photos!";
                return false;
            }
            return true;
        }

        private string[] _uploadFiles(string basePath, ParkSurveySheetForm model)
        {
            string guid = model.Id;
            string uploadSpace = basePath + guid + "\\";
            string photoUploadSpace = uploadSpace + "img\\";
            string dbPhotoPath = "";
            Directory.CreateDirectory(uploadSpace);
            Directory.CreateDirectory(photoUploadSpace);
            string SurveyDataSheetPath = uploadSpace + model.TranscriptFile.FileName;

            // 寫入現勘資料表
            using (FileStream fileStream = System.IO.File.Create(SurveyDataSheetPath))
            {
                model.TranscriptFile.CopyTo(fileStream);
                fileStream.Flush();
            }
            // 寫入照片檔案
            for (int i = 0; i < model.SurveyPhoto.Count; i++)
            {
                string photoPath = photoUploadSpace + model.SurveyPhoto[i].FileName;
                using (FileStream fileStream = System.IO.File.Create(photoPath))
                {
                    model.SurveyPhoto[i].CopyTo(fileStream);
                    fileStream.Flush();
                }
                dbPhotoPath += photoPath + "|";
            }
            return new string[] { SurveyDataSheetPath, dbPhotoPath };
        }



        // GET: Park
        public async Task<IActionResult> Index()
        {
            var webApiContext = _context.ParkSurveyDataSheet.Include(p => p.AppraisalObject).Include(p => p.AssetType).Include(p => p.AssignMethod).Include(p => p.BuildingRightsStatus).Include(p => p.BuildingStructure).Include(p => p.BuildingUsage).Include(p => p.EvaluationRightsType).Include(p => p.LandRightsStatus).Include(p => p.ParkMethod).Include(p => p.ParkType).Include(p => p.PriceType);

            foreach (var item in webApiContext)
            {
                if (item.TranscriptPath != null)
                {
                    if (item.TranscriptPath.Split("wwwroot").Count() > 1)
                    {
                        item.TranscriptPath = item.TranscriptPath.Split("wwwroot")[1];
                    }
                }

                if (item.PhotoPath != null)
                {
                    if (item.PhotoPath.Split('|').Count()>1)
                    {
                        var paths = item.PhotoPath.Split('|').SkipLast(1).ToList();
                        var new_paths = new List<string>();
                        foreach (var img in paths)
                        {
                            new_paths.Add(img.Split("wwwroot")[1]);
                        }
                        item.PhotoPath = string.Join('|', new_paths);
                    }
                }

            }

            return View(await webApiContext.ToListAsync());
        }

        // GET: Park/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parkSurveyDataSheet = await _context.ParkSurveyDataSheet
                .Include(p => p.AppraisalObject)
                .Include(p => p.AssetType)
                .Include(p => p.AssignMethod)
                .Include(p => p.BuildingRightsStatus)
                .Include(p => p.BuildingStructure)
                .Include(p => p.BuildingUsage)
                .Include(p => p.EvaluationRightsType)
                .Include(p => p.LandRightsStatus)
                .Include(p => p.ParkMethod)
                .Include(p => p.ParkType)
                .Include(p => p.PriceType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parkSurveyDataSheet == null)
            {
                return NotFound();
            }

            string fileRelative = "";
            if (parkSurveyDataSheet.TranscriptPath != null)
            {
                var file = parkSurveyDataSheet.TranscriptPath;
                if (file.Split("wwwroot").Count()>1)
                {
                   fileRelative = file.Split("wwwroot")[1];
                }
            }

            List<string> imageList_Relative = new List<string>();
            if (parkSurveyDataSheet.PhotoPath != null)
            {
                var imageList = parkSurveyDataSheet.PhotoPath.Split('|').SkipLast(1).ToList();
                foreach (var im in imageList)
                {
                    imageList_Relative.Add(im.Split("wwwroot")[1]);
                }
            }


            ViewBag.FilePath = fileRelative;
            ViewBag.ImageList = imageList_Relative;

            return View(parkSurveyDataSheet);
        }

        // GET: Park/Create
        public async Task<IActionResult> CreateAsync()
        {

            //產生GUID
            ViewData["Id"] = Guid.NewGuid().ToString();
            //登入使用者，取得使用者ID
            var user = await _userManager.GetUserAsync(User);
            if (user != null)
            {
                ViewData["UserId"] = _userManager.GetUserId(User);
            }

            var countyList = _context.Administrative_Area.Select(x => new { CountyName = x.CountyName }).Distinct();

            ViewData["County"] = new SelectList(countyList, "CountyName", "CountyName", "臺北市");

            var TownList = _context.Administrative_Area.Select(x => new { CountyName = x.CountyName, TownName = x.TownName }).Where(x => x.CountyName == "臺北市").Distinct();
            ViewData["Town"] = new SelectList(TownList, "TownName", "TownName", "中正區");

            return View();
        }

        // POST: Park/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,AssetTypeId,LandMarkCounty,LandMarkVillage,LandMarkName,LandMarkCode,BuildMarkCounty,BuildMarkVillage,BuildMarkName,BuildMarkCode,BuildAddressCounty,BuildAddressVillage,BuildAddress,ParkArea,ParkTypeId,ParkMethodId,LandRightsOwner,LandRightsStatusId,LandRightsHolding,BuildingRightsOwner,BuildingRightsStatusId,BuildingRightsHolding,OtherRights,AssignMethodId,LandUses,BuildingCoverageRatio,FloorAreaRatio,BuildingUsageId,BuildingStructureId,BuildingFinishDate,BuildingUpFloor,BuildingDownFloor,SurveyFloor,ParkWidth,ParkHeight,AllowSuv,InspectionDate,ValueOpinionDate,AppraisalObjectId,AppraisalDescription,PriceTypeId,EvaluationRightsTypeId,AppraisalCondition,SurveyorName,SurveyDescription,TranscriptFile,SurveyPhoto")] ParkSurveySheetForm parkSurveyDataSheet)
        {
            // 檢查檔案是否上傳
            if (!_fileChecking(parkSurveyDataSheet))
            {
                return StatusCode(422, _fileErrorResponse);
            }

            // 檢查上傳路徑是否存在
            if (!Directory.Exists(_parkSDS_path))
            {
                Directory.CreateDirectory(_parkSDS_path);
            }

            // 上傳檔案
            string[] filePathMeta = _uploadFiles(_parkSDS_path, parkSurveyDataSheet);

            parkSurveyDataSheet.TranscriptPath = filePathMeta[0];
            parkSurveyDataSheet.PhotoPath = filePathMeta[1];

            //
            // 新增現勘資料表進資料庫
            //
            ParkAssetType assetType = _context.Park_AssetType.Single(a => a.Id == parkSurveyDataSheet.AssetTypeId);
            ParkLandRightsStatus landRightStatus = _context.Park_LandRightsStatus.Single(l => l.Id == parkSurveyDataSheet.LandRightsStatusId);
            ParkBuildingRightsStatus buildingRightStatus = _context.Park_BuildingRightsStatus.Single(b => b.Id == parkSurveyDataSheet.BuildingRightsStatusId);
            ParkBuildingUsage buildingUsage = _context.Park_BuildingUsage.Single(b => b.Id == parkSurveyDataSheet.BuildingUsageId);
            ParkBuildingStructure buildingStructure = _context.Park_BuildingStructure.Single(b => b.Id == parkSurveyDataSheet.BuildingStructureId);
            ParkAppraisalObject appraisalObject = _context.Park_AppraisalObject.Single(a => a.Id == parkSurveyDataSheet.AppraisalObjectId);
            ParkPriceType priveType = _context.Park_PriceType.Single(p => p.Id == parkSurveyDataSheet.PriceTypeId);
            ParkEvaluationRightsType evaluationRightsType = _context.Park_EvaluationRightsType.Single(e => e.Id == parkSurveyDataSheet.EvaluationRightsTypeId);
            ParkAssignMethod parkAssignMethod = _context.ParkAssignMethod.Single(a => a.Id == parkSurveyDataSheet.AssignMethodId);
            ParkMethod parkMethod = _context.ParkMethod.Single(a => a.Id == parkSurveyDataSheet.ParkMethodId);
            ParkType parkType = _context.ParkType.Single(a => a.Id == parkSurveyDataSheet.ParkTypeId);

            parkSurveyDataSheet.AssetType = assetType;
            parkSurveyDataSheet.LandRightsStatus = landRightStatus;
            parkSurveyDataSheet.BuildingRightsStatus = buildingRightStatus;
            parkSurveyDataSheet.BuildingUsage = buildingUsage;
            parkSurveyDataSheet.BuildingStructure = buildingStructure;
            parkSurveyDataSheet.AppraisalObject = appraisalObject;
            parkSurveyDataSheet.PriceType = priveType;
            parkSurveyDataSheet.EvaluationRightsType = evaluationRightsType;
            parkSurveyDataSheet.AssignMethod = parkAssignMethod;
            parkSurveyDataSheet.ParkMethod = parkMethod;
            parkSurveyDataSheet.ParkType = parkType;

            if (ModelState.IsValid)
            {
                _context.Add((ParkSurveyDataSheet)parkSurveyDataSheet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View((ParkSurveyDataSheet)parkSurveyDataSheet);
        }

        // GET: Park/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parkSurveyDataSheet = await _context.ParkSurveyDataSheet.FindAsync(id);
            if (parkSurveyDataSheet == null)
            {
                return NotFound();
            }
            var form = new ParkSurveySheetForm().convert(parkSurveyDataSheet);

            //登入使用者，取得使用者ID
            var user = await _userManager.GetUserAsync(User);
            if (user != null)
            {
                ViewData["UserId"] = _userManager.GetUserId(User);
            }

            var countyList = _context.Administrative_Area.Select(x => new { CountyName = x.CountyName }).Distinct();

            ViewData["County"] = new SelectList(countyList, "CountyName", "CountyName", "臺北市");

            var TownList = _context.Administrative_Area.Select(x => new { CountyName = x.CountyName, TownName = x.TownName }).Where(x => x.CountyName == "臺北市").Distinct();
            ViewData["Town"] = new SelectList(TownList, "TownName", "TownName", "中正區");

            ViewData["Transcript"] = buildingSurveyDataSheet.TranscriptPath;
            ViewData["Photos"] = buildingSurveyDataSheet.PhotoPath;

            return View(form);
        }

        // POST: Park/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,UserId,AssetTypeId,LandMarkCounty,LandMarkVillage,LandMarkName,LandMarkCode,BuildMarkCounty,BuildMarkVillage,BuildMarkName,BuildMarkCode,BuildAddressCounty,BuildAddressVillage,BuildAddress,ParkArea,ParkTypeId,ParkMethodId,LandRightsOwner,LandRightsStatusId,LandRightsHolding,BuildingRightsOwner,BuildingRightsStatusId,BuildingRightsHolding,OtherRights,AssignMethodId,LandUses,BuildingCoverageRatio,FloorAreaRatio,BuildingUsageId,BuildingStructureId,BuildingFinishDate,BuildingUpFloor,BuildingDownFloor,SurveyFloor,ParkWidth,ParkHeight,AllowSuv,InspectionDate,ValueOpinionDate,AppraisalObjectId,AppraisalDescription,PriceTypeId,EvaluationRightsTypeId,AppraisalCondition,SurveyorName,SurveyDescription,TranscriptFile,SurveyPhoto")] ParkSurveySheetForm parkSurveyDataSheet)
        {
            if (id != parkSurveyDataSheet.Id)
            {
                return NotFound();
            }

            // 檢查檔案是否上傳
            if (_fileChecking(parkSurveyDataSheet))
            {
                // 檢查上傳路徑是否存在
                if (!Directory.Exists(_parkSDS_path))
                {
                    Directory.CreateDirectory(_parkSDS_path);
                }

                // 上傳檔案
                string[] filePathMeta = _uploadFiles(_parkSDS_path, parkSurveyDataSheet);

                parkSurveyDataSheet.TranscriptPath = filePathMeta[0];
                parkSurveyDataSheet.PhotoPath = filePathMeta[1];
            }


            //
            // 新增現勘資料表進資料庫
            //
            ParkAssetType assetType = _context.Park_AssetType.Single(a => a.Id == parkSurveyDataSheet.AssetTypeId);
            ParkLandRightsStatus landRightStatus = _context.Park_LandRightsStatus.Single(l => l.Id == parkSurveyDataSheet.LandRightsStatusId);
            ParkBuildingRightsStatus buildingRightStatus = _context.Park_BuildingRightsStatus.Single(b => b.Id == parkSurveyDataSheet.BuildingRightsStatusId);
            ParkBuildingUsage buildingUsage = _context.Park_BuildingUsage.Single(b => b.Id == parkSurveyDataSheet.BuildingUsageId);
            ParkBuildingStructure buildingStructure = _context.Park_BuildingStructure.Single(b => b.Id == parkSurveyDataSheet.BuildingStructureId);
            ParkAppraisalObject appraisalObject = _context.Park_AppraisalObject.Single(a => a.Id == parkSurveyDataSheet.AppraisalObjectId);
            ParkPriceType priveType = _context.Park_PriceType.Single(p => p.Id == parkSurveyDataSheet.PriceTypeId);
            ParkEvaluationRightsType evaluationRightsType = _context.Park_EvaluationRightsType.Single(e => e.Id == parkSurveyDataSheet.EvaluationRightsTypeId);
            ParkAssignMethod parkAssignMethod = _context.ParkAssignMethod.Single(a => a.Id == parkSurveyDataSheet.AssignMethodId);
            ParkMethod parkMethod = _context.ParkMethod.Single(a => a.Id == parkSurveyDataSheet.ParkMethodId);
            ParkType parkType = _context.ParkType.Single(a => a.Id == parkSurveyDataSheet.ParkTypeId);

            parkSurveyDataSheet.AssetType = assetType;
            parkSurveyDataSheet.LandRightsStatus = landRightStatus;
            parkSurveyDataSheet.BuildingRightsStatus = buildingRightStatus;
            parkSurveyDataSheet.BuildingUsage = buildingUsage;
            parkSurveyDataSheet.BuildingStructure = buildingStructure;
            parkSurveyDataSheet.AppraisalObject = appraisalObject;
            parkSurveyDataSheet.PriceType = priveType;
            parkSurveyDataSheet.EvaluationRightsType = evaluationRightsType;
            parkSurveyDataSheet.AssignMethod = parkAssignMethod;
            parkSurveyDataSheet.ParkMethod = parkMethod;
            parkSurveyDataSheet.ParkType = parkType;

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(parkSurveyDataSheet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParkSurveyDataSheetExists(parkSurveyDataSheet.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            return View((ParkSurveyDataSheet)parkSurveyDataSheet);           
        }

        // GET: Park/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parkSurveyDataSheet = await _context.ParkSurveyDataSheet
                .Include(p => p.AppraisalObject)
                .Include(p => p.AssetType)
                .Include(p => p.AssignMethod)
                .Include(p => p.BuildingRightsStatus)
                .Include(p => p.BuildingStructure)
                .Include(p => p.BuildingUsage)
                .Include(p => p.EvaluationRightsType)
                .Include(p => p.LandRightsStatus)
                .Include(p => p.ParkMethod)
                .Include(p => p.ParkType)
                .Include(p => p.PriceType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parkSurveyDataSheet == null)
            {
                return NotFound();
            }

            return View(parkSurveyDataSheet);
        }

        // POST: Park/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var parkSurveyDataSheet = await _context.ParkSurveyDataSheet.FindAsync(id);
            _context.ParkSurveyDataSheet.Remove(parkSurveyDataSheet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //POST: Park/getTownList
        [HttpPost]
        public PartialViewResult getTownList(string countyName)
        {
            var TownList = _context.Administrative_Area.Select(x => new { CountyName = x.CountyName, TownName = x.TownName }).Where(x => x.CountyName == countyName).Distinct();
            ViewData["Town"] = new SelectList(TownList, "TownName", "TownName");

            var partial = PartialView("townDropdown");
            partial.ViewData = ViewData;

            return partial;
        }

        private bool ParkSurveyDataSheetExists(string id)
        {
            return _context.ParkSurveyDataSheet.Any(e => e.Id == id);
        }
    }
}
