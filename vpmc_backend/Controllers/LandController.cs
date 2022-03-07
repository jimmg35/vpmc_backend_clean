using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using vpmc_backend.Areas.Identity.Data;
using vpmc_backend.Models;

namespace vpmc_backend.Controllers
{
    public class LandController : Controller
    {
        public static IWebHostEnvironment _environment;
        private readonly WebApiContext _context;
        private string _landSDS_path;
        private readonly UserManager<vpmc_backendUser> _userManager;
        private readonly SignInManager<vpmc_backendUser> _signInManager;
        private string _fileErrorResponse;

        public LandController(WebApiContext context, IWebHostEnvironment environment, UserManager<vpmc_backendUser> userManager, SignInManager<vpmc_backendUser> signInManager)
        {
            _context = context;
            _environment = environment;
            _landSDS_path = _environment.WebRootPath + "\\Upload\\LandSurveyDataSheets\\";
            _userManager = userManager;
            _signInManager = signInManager;
        }

        private bool _fileChecking(LandSurveySheetForm model)
        {
            // 檢查檔案是否上傳
            if (model.TranscriptFile == null)
            {
                _fileErrorResponse = "未上傳謄本";
                return false;
            }
            if (model.SurveyPhoto == null)
            {
                _fileErrorResponse = "未上傳相片";
                return false;
            }
            return true;
        }

        private string[] _uploadFiles(string basePath, LandSurveySheetForm model)
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

        // GET: Land
        public async Task<IActionResult> Index()
        {
            var webApiContext = _context.LandSurveyDataSheet.Include(l => l.AppraisalObject).Include(l => l.AssetType).Include(l => l.EvaluationRightsType).Include(l => l.LandRightsStatus).Include(l => l.PriceType);

            foreach (var item in webApiContext)
            {
                if (item.TranscriptPath != null)
                {
                    item.TranscriptPath = item.TranscriptPath.Split("wwwroot")[1];
                }
                if (item.PhotoPath != null)
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

            return View(await webApiContext.ToListAsync());
        }

        // GET: Land/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var landSurveyDataSheet = await _context.LandSurveyDataSheet
                .Include(l => l.AppraisalObject)
                .Include(l => l.AssetType)
                .Include(l => l.EvaluationRightsType)
                .Include(l => l.LandRightsStatus)
                .Include(l => l.PriceType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (landSurveyDataSheet == null)
            {
                return NotFound();
            }

            string fileRelative = "";
            if (landSurveyDataSheet.TranscriptPath != null)
            {
                var file = landSurveyDataSheet.TranscriptPath;
                if (file.Split("wwwroot").Count() > 1)
                {
                    fileRelative = file.Split("wwwroot")[1];
                }
            }

            List<string> imageList_Relative = new List<string>();
            if (landSurveyDataSheet.PhotoPath != null)
            {
                var imageList = landSurveyDataSheet.PhotoPath.Split('|').SkipLast(1).ToList();
                foreach (var im in imageList)
                {
                    imageList_Relative.Add(im.Split("wwwroot")[1]);
                }
            }

            ViewBag.FilePath = fileRelative;
            ViewBag.ImageList = imageList_Relative;

            return View(landSurveyDataSheet);
        }

        // GET: Land/Create
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

        // POST: Land/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,AssetTypeId,LandMarkCounty,LandMarkVillage,LandMarkName,LandMarkCode,BuildMarkCounty,BuildMarkVillage,BuildMarkName,BuildMarkCode,BuildAddressCounty,BuildAddressVillage,BuildAddress,LandArea,LandRightsOwner,LandRightsStatusId,LandRightsHolding,OtherRights,LandUses,BuildingCoverageRatio,FloorAreaRatio,InspectionDate,ValueOpinionDate,AppraisalObjectId,AppraisalDescription,PriceTypeId,EvaluationRightsTypeId,AppraisalCondition,SurveyorName,SurveyDescription,TranscriptFile,SurveyPhoto")] LandSurveySheetForm landSurveyDataSheet)
        {
            // 檢查檔案是否上傳
            if (!_fileChecking(landSurveyDataSheet))
            {
                return StatusCode(422, _fileErrorResponse);
            }

            // 檢查上傳路徑是否存在
            if (!Directory.Exists(_landSDS_path))
            {
                Directory.CreateDirectory(_landSDS_path);
            }

            // 上傳檔案
            string[] filePathMeta = _uploadFiles(_landSDS_path, landSurveyDataSheet);

            landSurveyDataSheet.TranscriptPath = filePathMeta[0];
            landSurveyDataSheet.PhotoPath = filePathMeta[1];

            //
            // 新增現勘資料表進資料庫
            //
            LandAssetType assetType = _context.Land_AssetType.Single(a => a.Id == landSurveyDataSheet.AssetTypeId);
            LandLandRightsStatus landRightStatus = _context.Land_LandRightsStatus.Single(l => l.Id == landSurveyDataSheet.LandRightsStatusId);
            LandAppraisalObject appraisalObject = _context.Land_AppraisalObject.Single(a => a.Id == landSurveyDataSheet.AppraisalObjectId);
            LandPriceType priveType = _context.Land_PriceType.Single(p => p.Id == landSurveyDataSheet.PriceTypeId);
            LandEvaluationRightsType evaluationRightsType = _context.Land_EvaluationRightsType.Single(e => e.Id == landSurveyDataSheet.EvaluationRightsTypeId);

            landSurveyDataSheet.AssetType = assetType;
            landSurveyDataSheet.LandRightsStatus = landRightStatus;
            landSurveyDataSheet.AppraisalObject = appraisalObject;
            landSurveyDataSheet.PriceType = priveType;
            landSurveyDataSheet.EvaluationRightsType = evaluationRightsType;


            if (ModelState.IsValid)
            {
                _context.Add((LandSurveyDataSheet)landSurveyDataSheet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View((LandSurveyDataSheet)landSurveyDataSheet);
        }

        // GET: Land/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var landSurveyDataSheet = await _context.LandSurveyDataSheet.FindAsync(id);
            if (landSurveyDataSheet == null)
            {
                return NotFound();
            }

            var form = new LandSurveySheetForm().convert(landSurveyDataSheet);

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

            ViewData["Transcript"] = landSurveyDataSheet.TranscriptPath;
            ViewData["Photos"] = landSurveyDataSheet.PhotoPath;

            return View(form);
        }

        // POST: Land/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,UserId,AssetTypeId,LandMarkCounty,LandMarkVillage,LandMarkName,LandMarkCode,BuildMarkCounty,BuildMarkVillage,BuildMarkName,BuildMarkCode,BuildAddressCounty,BuildAddressVillage,BuildAddress,LandArea,LandRightsOwner,LandRightsStatusId,LandRightsHolding,OtherRights,LandUses,BuildingCoverageRatio,FloorAreaRatio,InspectionDate,ValueOpinionDate,AppraisalObjectId,AppraisalDescription,PriceTypeId,EvaluationRightsTypeId,AppraisalCondition,SurveyorName,SurveyDescription,TranscriptFile,SurveyPhoto, TranscriptPath, PhotoPath")] LandSurveySheetForm landSurveyDataSheet)
        {
            if (id != landSurveyDataSheet.Id)
            {
                return NotFound();
            }

            // 檢查檔案是否上傳
            if (landSurveyDataSheet.SurveyPhoto != null || landSurveyDataSheet.TranscriptFile != null)
            {
                if (!_fileChecking(landSurveyDataSheet))
                {
                    return StatusCode(422, _fileErrorResponse);
                }
                // 檢查上傳路徑是否存在
                if (!Directory.Exists(_landSDS_path))
                {
                    Directory.CreateDirectory(_landSDS_path);
                }

                // 上傳檔案
                string[] filePathMeta = _uploadFiles(_landSDS_path, landSurveyDataSheet);

                landSurveyDataSheet.TranscriptPath = filePathMeta[0];
                landSurveyDataSheet.PhotoPath = filePathMeta[1];

            }

            //
            // 新增現勘資料表進資料庫
            //
            LandAssetType assetType = _context.Land_AssetType.Single(a => a.Id == landSurveyDataSheet.AssetTypeId);
            LandLandRightsStatus landRightStatus = _context.Land_LandRightsStatus.Single(l => l.Id == landSurveyDataSheet.LandRightsStatusId);
            LandAppraisalObject appraisalObject = _context.Land_AppraisalObject.Single(a => a.Id == landSurveyDataSheet.AppraisalObjectId);
            LandPriceType priveType = _context.Land_PriceType.Single(p => p.Id == landSurveyDataSheet.PriceTypeId);
            LandEvaluationRightsType evaluationRightsType = _context.Land_EvaluationRightsType.Single(e => e.Id == landSurveyDataSheet.EvaluationRightsTypeId);

            landSurveyDataSheet.AssetType = assetType;
            landSurveyDataSheet.LandRightsStatus = landRightStatus;
            landSurveyDataSheet.AppraisalObject = appraisalObject;
            landSurveyDataSheet.PriceType = priveType;
            landSurveyDataSheet.EvaluationRightsType = evaluationRightsType;

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(landSurveyDataSheet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LandSurveyDataSheetExists(landSurveyDataSheet.Id))
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

            return View((LandSurveyDataSheet)landSurveyDataSheet);
        }

        // GET: Land/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var landSurveyDataSheet = await _context.LandSurveyDataSheet
                .Include(l => l.AppraisalObject)
                .Include(l => l.AssetType)
                .Include(l => l.EvaluationRightsType)
                .Include(l => l.LandRightsStatus)
                .Include(l => l.PriceType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (landSurveyDataSheet == null)
            {
                return NotFound();
            }

            return View(landSurveyDataSheet);
        }

        // POST: Land/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var landSurveyDataSheet = await _context.LandSurveyDataSheet.FindAsync(id);
            _context.LandSurveyDataSheet.Remove(landSurveyDataSheet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //POST: Land/getTownList
        [HttpPost]
        public PartialViewResult getTownList(string countyName)
        {
            var TownList = _context.Administrative_Area.Select(x => new { CountyName = x.CountyName, TownName = x.TownName }).Where(x => x.CountyName == countyName).Distinct();
            ViewData["Town"] = new SelectList(TownList, "TownName", "TownName");

            var partial = PartialView("townDropdown");
            partial.ViewData = ViewData;

            return partial;
        }


        private bool LandSurveyDataSheetExists(string id)
        {
            return _context.LandSurveyDataSheet.Any(e => e.Id == id);
        }
    }
}
