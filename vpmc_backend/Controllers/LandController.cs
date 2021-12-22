using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using vpmc_backend.Models;

namespace vpmc_backend.Controllers
{
    public class LandController : Controller
    {
        private readonly WebApiContext _context;

        public LandController(WebApiContext context)
        {
            _context = context;
        }

        // GET: Land
        public async Task<IActionResult> Index()
        {
            var webApiContext = _context.LandSurveyDataSheet.Include(l => l.AppraisalObject).Include(l => l.AssetType).Include(l => l.EvaluationRightsType).Include(l => l.LandRightsStatus).Include(l => l.PriceType);
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

            return View(landSurveyDataSheet);
        }

        // GET: Land/Create
        public IActionResult Create()
        {
            ViewData["AppraisalObjectId"] = new SelectList(_context.Land_AppraisalObject, "Id", "Id");
            ViewData["AssetTypeId"] = new SelectList(_context.Land_AssetType, "Id", "Id");
            ViewData["EvaluationRightsTypeId"] = new SelectList(_context.Land_EvaluationRightsType, "Id", "Id");
            ViewData["LandRightsStatusId"] = new SelectList(_context.Land_LandRightsStatus, "Id", "Id");
            ViewData["PriceTypeId"] = new SelectList(_context.Land_PriceType, "Id", "Id");
            return View();
        }

        // POST: Land/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,AssetTypeId,LandMarkCounty,LandMarkVillage,LandMarkName,LandMarkCode,BuildMarkCounty,BuildMarkVillage,BuildMarkName,BuildMarkCode,BuildAddressCounty,BuildAddressVillage,BuildAddress,LandArea,LandRightsOwner,LandRightsStatusId,LandRightsHolding,OtherRights,LandUses,BuildingCoverageRatio,FloorAreaRatio,InspectionDate,ValueOpinionDate,AppraisalObjectId,AppraisalDescription,PriceTypeId,EvaluationRightsTypeId,AppraisalCondition,SurveyorName,SurveyDescription,TranscriptPath,PhotoPath")] LandSurveyDataSheet landSurveyDataSheet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(landSurveyDataSheet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AppraisalObjectId"] = new SelectList(_context.Land_AppraisalObject, "Id", "Id", landSurveyDataSheet.AppraisalObjectId);
            ViewData["AssetTypeId"] = new SelectList(_context.Land_AssetType, "Id", "Id", landSurveyDataSheet.AssetTypeId);
            ViewData["EvaluationRightsTypeId"] = new SelectList(_context.Land_EvaluationRightsType, "Id", "Id", landSurveyDataSheet.EvaluationRightsTypeId);
            ViewData["LandRightsStatusId"] = new SelectList(_context.Land_LandRightsStatus, "Id", "Id", landSurveyDataSheet.LandRightsStatusId);
            ViewData["PriceTypeId"] = new SelectList(_context.Land_PriceType, "Id", "Id", landSurveyDataSheet.PriceTypeId);
            return View(landSurveyDataSheet);
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
            ViewData["AppraisalObjectId"] = new SelectList(_context.Land_AppraisalObject, "Id", "Id", landSurveyDataSheet.AppraisalObjectId);
            ViewData["AssetTypeId"] = new SelectList(_context.Land_AssetType, "Id", "Id", landSurveyDataSheet.AssetTypeId);
            ViewData["EvaluationRightsTypeId"] = new SelectList(_context.Land_EvaluationRightsType, "Id", "Id", landSurveyDataSheet.EvaluationRightsTypeId);
            ViewData["LandRightsStatusId"] = new SelectList(_context.Land_LandRightsStatus, "Id", "Id", landSurveyDataSheet.LandRightsStatusId);
            ViewData["PriceTypeId"] = new SelectList(_context.Land_PriceType, "Id", "Id", landSurveyDataSheet.PriceTypeId);
            return View(landSurveyDataSheet);
        }

        // POST: Land/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,UserId,AssetTypeId,LandMarkCounty,LandMarkVillage,LandMarkName,LandMarkCode,BuildMarkCounty,BuildMarkVillage,BuildMarkName,BuildMarkCode,BuildAddressCounty,BuildAddressVillage,BuildAddress,LandArea,LandRightsOwner,LandRightsStatusId,LandRightsHolding,OtherRights,LandUses,BuildingCoverageRatio,FloorAreaRatio,InspectionDate,ValueOpinionDate,AppraisalObjectId,AppraisalDescription,PriceTypeId,EvaluationRightsTypeId,AppraisalCondition,SurveyorName,SurveyDescription,TranscriptPath,PhotoPath")] LandSurveyDataSheet landSurveyDataSheet)
        {
            if (id != landSurveyDataSheet.Id)
            {
                return NotFound();
            }

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
            ViewData["AppraisalObjectId"] = new SelectList(_context.Land_AppraisalObject, "Id", "Id", landSurveyDataSheet.AppraisalObjectId);
            ViewData["AssetTypeId"] = new SelectList(_context.Land_AssetType, "Id", "Id", landSurveyDataSheet.AssetTypeId);
            ViewData["EvaluationRightsTypeId"] = new SelectList(_context.Land_EvaluationRightsType, "Id", "Id", landSurveyDataSheet.EvaluationRightsTypeId);
            ViewData["LandRightsStatusId"] = new SelectList(_context.Land_LandRightsStatus, "Id", "Id", landSurveyDataSheet.LandRightsStatusId);
            ViewData["PriceTypeId"] = new SelectList(_context.Land_PriceType, "Id", "Id", landSurveyDataSheet.PriceTypeId);
            return View(landSurveyDataSheet);
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

        private bool LandSurveyDataSheetExists(string id)
        {
            return _context.LandSurveyDataSheet.Any(e => e.Id == id);
        }
    }
}
