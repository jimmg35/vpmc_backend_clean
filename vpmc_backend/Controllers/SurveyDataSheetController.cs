using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using vpmc_backend.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Hosting;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace vpmc_backend.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyDataSheetController : ControllerBase
    {

        public static IWebHostEnvironment _environment;
        private readonly WebApiContext _context;
        private string _buildingSDS_path;
        private string _landSDS_path;
        private string _parkSDS_path;
        private string _fileErrorResponse;


        public SurveyDataSheetController(WebApiContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
            _buildingSDS_path = _environment.WebRootPath + "\\Upload\\BuildingSurveyDataSheets\\";
            _landSDS_path = _environment.WebRootPath + "\\Upload\\LandSurveyDataSheets\\";
            _parkSDS_path = _environment.WebRootPath + "\\Upload\\ParkSurveyDataSheets\\";
        }

        private bool _fileChecking(ISurveyDataSheetModel model)
        {
            // 檢查檔案是否上傳
            if (model.TranscriptFile.Length == 0)
            {
                _fileErrorResponse = "Missing Transcriptfile!";
                return false;
            }
            if (model.SurveyPhoto.Count == 0)
            {
                _fileErrorResponse = "Missing Photos!";
                return false;
            }
            return true;
        }

        private string[] _uploadFiles(string basePath, ISurveyDataSheetModel model)
        {
            string guid = Guid.NewGuid().ToString();
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
            return new string[] { guid, SurveyDataSheetPath, dbPhotoPath };
        }


        [AllowAnonymous]
        [HttpPost("addBuildingSurveyDataSheet")]
        [Consumes("multipart/form-data")]
        public IActionResult addBuildingSurveyDataSheet([FromForm] BuildingSurveyDataSheetModel model)
        {

            // 檢查檔案是否上傳
            if (!_fileChecking(model))
            {
                return StatusCode(422, _fileErrorResponse);
            }

            // 檢查上傳路徑是否存在
            if (!Directory.Exists(_buildingSDS_path))
            {
                Directory.CreateDirectory(_buildingSDS_path);
            }

            // 上傳檔案
            string[] filePathMeta = _uploadFiles(_buildingSDS_path, model);

            //
            // 新增現勘資料表進資料庫
            //
            BuildingAssetType assetType = _context.Building_AssetType.Single(a => a.Id == model.AssetType);
            BuildingLandRightsStatus landRightStatus = _context.Building_LandRightsStatus.Single(l => l.Id == model.LandRightsStatus);
            BuildingBuildingRightsStatus buildingRightStatus = _context.Building_BuildingRightsStatus.Single(b => b.Id == model.BuildingRightsStatus);
            BuildingBuildingUsage buildingUsage = _context.Building_BuildingUsage.Single(b => b.Id == model.BuildingUsage);
            BuildingBuildingStructure buildingStructure = _context.Building_BuildingStructure.Single(b => b.Id == model.BuildingStructure);
            BuildingAppraisalObject appraisalObject = _context.Building_AppraisalObject.Single(a => a.Id == model.AppraisalObject);
            BuildingPriceType priveType = _context.Building_PriceType.Single(p => p.Id == model.PriceType);
            BuildingEvaluationRightsType evaluationRightsType = _context.Building_EvaluationRightsType.Single(e => e.Id == model.EvaluationRightsType);
            _context.BuildingSurveyDataSheet.Add(
                new BuildingSurveyDataSheet
                {
                    Id = filePathMeta[0],
                    UserId = model.UserId,
                    AssetType = assetType,
                    LandMarkCounty = model.LandMarkCounty,
                    LandMarkVillage = model.LandMarkVillage,
                    LandMarkName = model.LandMarkName,
                    LandMarkCode = model.LandMarkCode,
                    BuildMarkCounty = model.BuildMarkCounty,
                    BuildMarkVillage = model.BuildMarkVillage,
                    BuildMarkName = model.BuildMarkName,
                    BuildMarkCode = model.BuildMarkCode,
                    BuildAddressCounty = model.BuildAddressCounty,
                    BuildAddressVillage = model.BuildAddressVillage,
                    BuildAddress = model.BuildAddress,
                    LandArea = model.LandArea,
                    BuildingArea = model.BuildingArea,
                    LandRightsOwner = model.LandRightsOwner,
                    LandRightsStatus = landRightStatus,
                    LandRightsHolding = model.LandRightsHolding,
                    BuildingRightsOwner = model.BuildingRightsOwner,
                    BuildingRightsStatus = buildingRightStatus,
                    BuildingRightsHolding = model.BuildingRightsHolding,
                    OtherRights = model.OtherRights,
                    LandUses = model.LandUses,
                    BuildingCoverageRatio = model.BuildingCoverageRatio,
                    FloorAreaRatio = model.FloorAreaRatio,
                    BuildingUsage = buildingUsage,
                    BuildingStructure = buildingStructure,
                    BuildingFinishDate = model.BuildingFinishDate,
                    BuildingUpFloor = model.BuildingUpFloor,
                    BuildingDownFloor = model.BuildingDownFloor,
                    SurveyFloor = model.SurveyFloor,
                    InspectionDate = model.InspectionDate,
                    ValueOpinionDate = model.ValueOpinionDate,
                    AppraisalObject = appraisalObject,
                    AppraisalDescription = model.AppraisalDescription,
                    PriceType = priveType,
                    EvaluationRightsType = evaluationRightsType,
                    AppraisalCondition = model.AppraisalCondition,
                    SurveyorName = model.SurveyorName,
                    SurveyDescription = model.SurveyDescription,
                    TranscriptPath = filePathMeta[1],
                    PhotoPath = filePathMeta[2]
                }
            );
            _context.SaveChanges();
            return Ok();
        }


        [AllowAnonymous]
        [HttpPost("addLandSurveyDataSheet")]
        [Consumes("multipart/form-data")]
        public IActionResult addLandSurveyDataSheet([FromForm] LandSurveyDataSheetModel model)
        {
            // 檢查檔案是否上傳
            if (!_fileChecking(model))
            {
                return StatusCode(422, _fileErrorResponse);
            }

            // 檢查上傳路徑是否存在
            if (!Directory.Exists(_landSDS_path))
            {
                Directory.CreateDirectory(_landSDS_path);
            }

            // 上傳檔案
            string[] filePathMeta = _uploadFiles(_landSDS_path, model);

            //
            // 新增現勘資料表進資料庫
            //
            LandAssetType assetType = _context.Land_AssetType.Single(a => a.Id == model.AssetType);
            LandLandRightsStatus landRightStatus = _context.Land_LandRightsStatus.Single(l => l.Id == model.LandRightsStatus);
            LandAppraisalObject appraisalObject = _context.Land_AppraisalObject.Single(a => a.Id == model.AppraisalObject);
            LandPriceType priveType = _context.Land_PriceType.Single(p => p.Id == model.PriceType);
            LandEvaluationRightsType evaluationRightsType = _context.Land_EvaluationRightsType.Single(e => e.Id == model.EvaluationRightsType);
            _context.LandSurveyDataSheet.Add(
                new LandSurveyDataSheet
                {
                    Id = filePathMeta[0],
                    UserId = model.UserId,
                    AssetType = assetType,
                    LandMarkCounty = model.LandMarkCounty,
                    LandMarkVillage = model.LandMarkVillage,
                    LandMarkName = model.LandMarkName,
                    LandMarkCode = model.LandMarkCode,
                    BuildMarkCounty = model.BuildMarkCounty,
                    BuildMarkVillage = model.BuildMarkVillage,
                    BuildMarkName = model.BuildMarkName,
                    BuildMarkCode = model.BuildMarkCode,
                    BuildAddressCounty = model.BuildAddressCounty,
                    BuildAddressVillage = model.BuildAddressVillage,
                    BuildAddress = model.BuildAddress,
                    LandArea = model.LandArea,
                    LandRightsOwner = model.LandRightsOwner,
                    LandRightsStatus = landRightStatus,
                    LandRightsHolding = model.LandRightsHolding,
                    OtherRights = model.OtherRights,
                    LandUses = model.LandUses,
                    BuildingCoverageRatio = model.BuildingCoverageRatio,
                    FloorAreaRatio = model.FloorAreaRatio,
                    InspectionDate = model.InspectionDate,
                    ValueOpinionDate = model.ValueOpinionDate,
                    AppraisalObject = appraisalObject,
                    AppraisalDescription = model.AppraisalDescription,
                    PriceType = priveType,
                    EvaluationRightsType = evaluationRightsType,
                    AppraisalCondition = model.AppraisalCondition,
                    SurveyorName = model.SurveyorName,
                    SurveyDescription = model.SurveyDescription,
                    TranscriptPath = filePathMeta[1],
                    PhotoPath = filePathMeta[2]
                }
            );
            _context.SaveChanges();
            return Ok();
        }



        [AllowAnonymous]
        [HttpPost("addParkSurveyDataSheet")]
        [Consumes("multipart/form-data")]
        public IActionResult addParkSurveyDataSheet([FromForm] ParkSurveyDataSheetModel model)
        {

            // 檢查檔案是否上傳
            if (!_fileChecking(model))
            {
                return StatusCode(422, _fileErrorResponse);
            }

            // 檢查上傳路徑是否存在
            if (!Directory.Exists(_parkSDS_path))
            {
                Directory.CreateDirectory(_parkSDS_path);
            }

            // 上傳檔案
            string[] filePathMeta = _uploadFiles(_parkSDS_path, model);

            //
            // 新增現勘資料表進資料庫
            //
            ParkAssetType assetType = _context.Park_AssetType.Single(a => a.Id == model.AssetType);
            ParkType parkType = _context.ParkType.Single(a => a.Id == model.ParkType);
            ParkMethod parkMethod = _context.ParkMethod.Single(a => a.Id == model.ParkMethod);
            ParkLandRightsStatus landRightStatus = _context.Park_LandRightsStatus.Single(l => l.Id == model.LandRightsStatus);
            ParkBuildingRightsStatus buildingRightStatus = _context.Park_BuildingRightsStatus.Single(b => b.Id == model.BuildingRightsStatus);
            ParkAssignMethod parkAssignMethod = _context.ParkAssignMethod.Single(a => a.Id == model.AssignMethod);
            ParkBuildingUsage buildingUsage = _context.Park_BuildingUsage.Single(b => b.Id == model.BuildingUsage);
            ParkBuildingStructure buildingStructure = _context.Park_BuildingStructure.Single(b => b.Id == model.BuildingStructure);
            ParkAppraisalObject appraisalObject = _context.Park_AppraisalObject.Single(a => a.Id == model.AppraisalObject);
            ParkPriceType priveType = _context.Park_PriceType.Single(p => p.Id == model.PriceType);
            ParkEvaluationRightsType evaluationRightsType = _context.Park_EvaluationRightsType.Single(e => e.Id == model.EvaluationRightsType);
            _context.ParkSurveyDataSheet.Add(
                new ParkSurveyDataSheet
                {
                    Id = filePathMeta[0],
                    UserId = model.UserId,
                    AssetType = assetType,
                    LandMarkCounty = model.LandMarkCounty,
                    LandMarkVillage = model.LandMarkVillage,
                    LandMarkName = model.LandMarkName,
                    LandMarkCode = model.LandMarkCode,
                    BuildMarkCounty = model.BuildMarkCounty,
                    BuildMarkVillage = model.BuildMarkVillage,
                    BuildMarkName = model.BuildMarkName,
                    BuildMarkCode = model.BuildMarkCode,
                    BuildAddressCounty = model.BuildAddressCounty,
                    BuildAddressVillage = model.BuildAddressVillage,
                    BuildAddress = model.BuildAddress,
                    ParkType = parkType,
                    ParkMethod = parkMethod,
                    LandRightsOwner = model.LandRightsOwner,
                    LandRightsStatus = landRightStatus,
                    LandRightsHolding = model.LandRightsHolding,
                    BuildingRightsOwner = model.BuildingRightsOwner,
                    BuildingRightsStatus = buildingRightStatus,
                    BuildingRightsHolding = model.BuildingRightsHolding,
                    OtherRights = model.OtherRights,
                    AssignMethod = parkAssignMethod,
                    LandUses = model.LandUses,
                    BuildingCoverageRatio = model.BuildingCoverageRatio,
                    FloorAreaRatio = model.FloorAreaRatio,
                    BuildingUsage = buildingUsage,
                    BuildingStructure = buildingStructure,
                    BuildingFinishDate = model.BuildingFinishDate,
                    BuildingUpFloor = model.BuildingUpFloor,
                    BuildingDownFloor = model.BuildingDownFloor,
                    SurveyFloor = model.SurveyFloor,
                    ParkWidth = model.ParkWidth,
                    ParkHeight = model.ParkHeight,
                    AllowSuv = model.AllowSuv,
                    InspectionDate = model.InspectionDate,
                    ValueOpinionDate = model.ValueOpinionDate,
                    AppraisalObject = appraisalObject,
                    AppraisalDescription = model.AppraisalDescription,
                    PriceType = priveType,
                    EvaluationRightsType = evaluationRightsType,
                    AppraisalCondition = model.AppraisalCondition,
                    SurveyorName = model.SurveyorName,
                    SurveyDescription = model.SurveyDescription,
                    TranscriptPath = filePathMeta[1],
                    PhotoPath = filePathMeta[2]
                }
            );
            _context.SaveChanges();
            return Ok();
        }




    }
}
