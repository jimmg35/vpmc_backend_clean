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

namespace vpmc_backend.Controllers
{
    public class BuildingController : Controller
    {
        public static IWebHostEnvironment _environment;
        private readonly WebApiContext _context;
        private string _buildingSDS_path;

        public BuildingController(WebApiContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
            _buildingSDS_path = _environment.WebRootPath + "\\Upload\\BuildingSurveyDataSheets\\";
        }

        // GET: BuildingSurveyDataSheets
        public async Task<IActionResult> Index()
        {
            var webApiContext = _context.BuildingSurveyDataSheet.Include(b => b.AppraisalObject).Include(b => b.AssetType).Include(b => b.BuildingRightsStatus).Include(b => b.BuildingStructure).Include(b => b.BuildingUsage).Include(b => b.EvaluationRightsType).Include(b => b.LandRightsStatus).Include(b => b.PriceType);
            return View(await webApiContext.ToListAsync());
        }

        // GET: BuildingSurveyDataSheets/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var buildingSurveyDataSheet = await _context.BuildingSurveyDataSheet
                .Include(b => b.AppraisalObject)
                .Include(b => b.AssetType)
                .Include(b => b.BuildingRightsStatus)
                .Include(b => b.BuildingStructure)
                .Include(b => b.BuildingUsage)
                .Include(b => b.EvaluationRightsType)
                .Include(b => b.LandRightsStatus)
                .Include(b => b.PriceType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (buildingSurveyDataSheet == null)
            {
                return NotFound();
            }

            return View(buildingSurveyDataSheet);
        }

        // GET: BuildingSurveyDataSheets/Create
        public IActionResult Create()
        {
            ViewData["AppraisalObjectId"] = new SelectList(_context.Building_AppraisalObject, "Id", "Id");
            ViewData["AssetTypeId"] = new SelectList(_context.Building_AssetType, "Id", "Id");
            ViewData["BuildingRightsStatusId"] = new SelectList(_context.Building_BuildingRightsStatus, "Id", "Id");
            ViewData["BuildingStructureId"] = new SelectList(_context.Building_BuildingStructure, "Id", "Id");
            ViewData["BuildingUsageId"] = new SelectList(_context.Building_BuildingUsage, "Id", "Id");
            ViewData["EvaluationRightsTypeId"] = new SelectList(_context.Building_EvaluationRightsType, "Id", "Id");
            ViewData["LandRightsStatusId"] = new SelectList(_context.Building_LandRightsStatus, "Id", "Id");
            ViewData["PriceTypeId"] = new SelectList(_context.Building_PriceType, "Id", "Id");
            return View();
        }

        // POST: BuildingSurveyDataSheets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,AssetTypeId,LandMarkCounty,LandMarkVillage,LandMarkName,LandMarkCode,BuildMarkCounty,BuildMarkVillage,BuildMarkName,BuildMarkCode,BuildAddressCounty,BuildAddressVillage,BuildAddress,LandArea,BuildingArea,LandRightsOwner,LandRightsStatusId,LandRightsHolding,BuildingRightsOwner,BuildingRightsStatusId,BuildingRightsHolding,OtherRights,LandUses,BuildingCoverageRatio,FloorAreaRatio,BuildingUsageId,BuildingStructureId,BuildingFinishDate,BuildingUpFloor,BuildingDownFloor,SurveyFloor,InspectionDate,ValueOpinionDate,AppraisalObjectId,AppraisalDescription,PriceTypeId,EvaluationRightsTypeId,AppraisalCondition,SurveyorName,SurveyDescription,TranscriptPath,PhotoPath")] BuildingSurveyDataSheet buildingSurveyDataSheet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(buildingSurveyDataSheet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AppraisalObjectId"] = new SelectList(_context.Building_AppraisalObject, "Id", "Id", buildingSurveyDataSheet.AppraisalObjectId);
            ViewData["AssetTypeId"] = new SelectList(_context.Building_AssetType, "Id", "Id", buildingSurveyDataSheet.AssetTypeId);
            ViewData["BuildingRightsStatusId"] = new SelectList(_context.Building_BuildingRightsStatus, "Id", "Id", buildingSurveyDataSheet.BuildingRightsStatusId);
            ViewData["BuildingStructureId"] = new SelectList(_context.Building_BuildingStructure, "Id", "Id", buildingSurveyDataSheet.BuildingStructureId);
            ViewData["BuildingUsageId"] = new SelectList(_context.Building_BuildingUsage, "Id", "Id", buildingSurveyDataSheet.BuildingUsageId);
            ViewData["EvaluationRightsTypeId"] = new SelectList(_context.Building_EvaluationRightsType, "Id", "Id", buildingSurveyDataSheet.EvaluationRightsTypeId);
            ViewData["LandRightsStatusId"] = new SelectList(_context.Building_LandRightsStatus, "Id", "Id", buildingSurveyDataSheet.LandRightsStatusId);
            ViewData["PriceTypeId"] = new SelectList(_context.Building_PriceType, "Id", "Id", buildingSurveyDataSheet.PriceTypeId);
            return View(buildingSurveyDataSheet);
        }

        private string[] _uploadSurveyPhoto(List<IFormFile> files)
        {
            string basePath = _buildingSDS_path;
            string guid = Guid.NewGuid().ToString();
            string uploadSpace = basePath + guid + "\\";
            string photoUploadSpace = uploadSpace + "img\\";
            string dbPhotoPath = "";
            Directory.CreateDirectory(uploadSpace);
            Directory.CreateDirectory(photoUploadSpace);
            //string SurveyDataSheetPath = uploadSpace + model.TranscriptFile.FileName;
            /*
            // 寫入現勘資料表
            using (FileStream fileStream = System.IO.File.Create(SurveyDataSheetPath))
            {
                model.TranscriptFile.CopyTo(fileStream);
                fileStream.Flush();
            }
            */
            // 寫入照片檔案
            for (int i = 0; i < files.Count; i++)
            {
                string photoPath = photoUploadSpace + files[i].FileName;
                using (FileStream fileStream = System.IO.File.Create(photoPath))
                {
                    files[i].CopyTo(fileStream);
                    fileStream.Flush();
                }
                dbPhotoPath += photoPath + "|";
            }
            return new string[] { guid, dbPhotoPath };
        }

        // GET: BuildingSurveyDataSheets/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var buildingSurveyDataSheet = await _context.BuildingSurveyDataSheet.FindAsync(id);
            if (buildingSurveyDataSheet == null)
            {
                return NotFound();
            }
            ViewData["AppraisalObjectId"] = new SelectList(_context.Building_AppraisalObject, "Id", "Id", buildingSurveyDataSheet.AppraisalObjectId);
            ViewData["AssetTypeId"] = new SelectList(_context.Building_AssetType, "Id", "Id", buildingSurveyDataSheet.AssetTypeId);
            ViewData["BuildingRightsStatusId"] = new SelectList(_context.Building_BuildingRightsStatus, "Id", "Id", buildingSurveyDataSheet.BuildingRightsStatusId);
            ViewData["BuildingStructureId"] = new SelectList(_context.Building_BuildingStructure, "Id", "Id", buildingSurveyDataSheet.BuildingStructureId);
            ViewData["BuildingUsageId"] = new SelectList(_context.Building_BuildingUsage, "Id", "Id", buildingSurveyDataSheet.BuildingUsageId);
            ViewData["EvaluationRightsTypeId"] = new SelectList(_context.Building_EvaluationRightsType, "Id", "Id", buildingSurveyDataSheet.EvaluationRightsTypeId);
            ViewData["LandRightsStatusId"] = new SelectList(_context.Building_LandRightsStatus, "Id", "Id", buildingSurveyDataSheet.LandRightsStatusId);
            ViewData["PriceTypeId"] = new SelectList(_context.Building_PriceType, "Id", "Id", buildingSurveyDataSheet.PriceTypeId);
            return View(buildingSurveyDataSheet);
        }

        // POST: BuildingSurveyDataSheets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,UserId,AssetTypeId,LandMarkCounty,LandMarkVillage,LandMarkName,LandMarkCode,BuildMarkCounty,BuildMarkVillage,BuildMarkName,BuildMarkCode,BuildAddressCounty,BuildAddressVillage,BuildAddress,LandArea,BuildingArea,LandRightsOwner,LandRightsStatusId,LandRightsHolding,BuildingRightsOwner,BuildingRightsStatusId,BuildingRightsHolding,OtherRights,LandUses,BuildingCoverageRatio,FloorAreaRatio,BuildingUsageId,BuildingStructureId,BuildingFinishDate,BuildingUpFloor,BuildingDownFloor,SurveyFloor,InspectionDate,ValueOpinionDate,AppraisalObjectId,AppraisalDescription,PriceTypeId,EvaluationRightsTypeId,AppraisalCondition,SurveyorName,SurveyDescription,TranscriptPath,PhotoPath")] BuildingSurveyDataSheet buildingSurveyDataSheet)
        {
            if (id != buildingSurveyDataSheet.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(buildingSurveyDataSheet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BuildingSurveyDataSheetExists(buildingSurveyDataSheet.Id))
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
            ViewData["AppraisalObjectId"] = new SelectList(_context.Building_AppraisalObject, "Id", "Id", buildingSurveyDataSheet.AppraisalObjectId);
            ViewData["AssetTypeId"] = new SelectList(_context.Building_AssetType, "Id", "Id", buildingSurveyDataSheet.AssetTypeId);
            ViewData["BuildingRightsStatusId"] = new SelectList(_context.Building_BuildingRightsStatus, "Id", "Id", buildingSurveyDataSheet.BuildingRightsStatusId);
            ViewData["BuildingStructureId"] = new SelectList(_context.Building_BuildingStructure, "Id", "Id", buildingSurveyDataSheet.BuildingStructureId);
            ViewData["BuildingUsageId"] = new SelectList(_context.Building_BuildingUsage, "Id", "Id", buildingSurveyDataSheet.BuildingUsageId);
            ViewData["EvaluationRightsTypeId"] = new SelectList(_context.Building_EvaluationRightsType, "Id", "Id", buildingSurveyDataSheet.EvaluationRightsTypeId);
            ViewData["LandRightsStatusId"] = new SelectList(_context.Building_LandRightsStatus, "Id", "Id", buildingSurveyDataSheet.LandRightsStatusId);
            ViewData["PriceTypeId"] = new SelectList(_context.Building_PriceType, "Id", "Id", buildingSurveyDataSheet.PriceTypeId);
            return View(buildingSurveyDataSheet);
        }

        // GET: BuildingSurveyDataSheets/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var buildingSurveyDataSheet = await _context.BuildingSurveyDataSheet
                .Include(b => b.AppraisalObject)
                .Include(b => b.AssetType)
                .Include(b => b.BuildingRightsStatus)
                .Include(b => b.BuildingStructure)
                .Include(b => b.BuildingUsage)
                .Include(b => b.EvaluationRightsType)
                .Include(b => b.LandRightsStatus)
                .Include(b => b.PriceType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (buildingSurveyDataSheet == null)
            {
                return NotFound();
            }

            return View(buildingSurveyDataSheet);
        }

        // POST: BuildingSurveyDataSheets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var buildingSurveyDataSheet = await _context.BuildingSurveyDataSheet.FindAsync(id);
            _context.BuildingSurveyDataSheet.Remove(buildingSurveyDataSheet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BuildingSurveyDataSheetExists(string id)
        {
            return _context.BuildingSurveyDataSheet.Any(e => e.Id == id);
        }
    }
}
