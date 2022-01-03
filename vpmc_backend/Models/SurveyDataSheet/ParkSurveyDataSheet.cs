using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vpmc_backend.Models
{
    public class ParkSurveyDataSheet
    {
        public string Id { get; set; } // Primary Key
        public string UserId { get; set; }
        //
        public int AssetTypeId { get; set; }
        public ParkAssetType AssetType { get; set; }
        //
        public string LandMarkCounty { get; set; }
        public string LandMarkVillage { get; set; }
        public string LandMarkName { get; set; }
        public string LandMarkCode { get; set; }
        //
        public string BuildMarkCounty { get; set; }
        public string BuildMarkVillage { get; set; }
        public string BuildMarkName { get; set; }
        public string BuildMarkCode { get; set; }
        //
        public string BuildAddressCounty { get; set; }
        public string BuildAddressVillage { get; set; }
        public string BuildAddress { get; set; }
        public double ParkArea { get; set; }
        public int ParkTypeId { get; set; }
        public ParkType ParkType { get; set; }
        public int ParkMethodId { get; set; }
        public ParkMethod ParkMethod { get; set; }
        //
        public string LandRightsOwner { get; set; }
        public int LandRightsStatusId { get; set; }
        public ParkLandRightsStatus LandRightsStatus { get; set; }
        public string LandRightsHolding { get; set; }
        public string BuildingRightsOwner { get; set; }
        public int BuildingRightsStatusId { get; set; }
        public ParkBuildingRightsStatus BuildingRightsStatus { get; set; }
        public string BuildingRightsHolding { get; set; }
        public string OtherRights { get; set; }
        public int AssignMethodId { get; set; }
        public ParkAssignMethod AssignMethod { get; set; }
        //
        public string LandUses { get; set; }
        public double BuildingCoverageRatio { get; set; }
        public double FloorAreaRatio { get; set; }
        public int BuildingUsageId { get; set; }
        public ParkBuildingUsage BuildingUsage { get; set; }
        public int BuildingStructureId { get; set; }
        public ParkBuildingStructure BuildingStructure { get; set; }
        public DateTime BuildingFinishDate { get; set; }
        public int BuildingUpFloor { get; set; }
        public int BuildingDownFloor { get; set; }
        public int SurveyFloor { get; set; }
        public double ParkWidth { get; set; }
        public double ParkHeight { get; set; }
        public bool AllowSuv { get; set; }
        //
        public DateTime InspectionDate { get; set; }
        public DateTime ValueOpinionDate { get; set; }
        //
        public int AppraisalObjectId { get; set; }
        public ParkAppraisalObject AppraisalObject { get; set; }
        public string AppraisalDescription { get; set; }
        //
        public int PriceTypeId { get; set; }
        public ParkPriceType PriceType { get; set; }
        public int EvaluationRightsTypeId { get; set; }
        public ParkEvaluationRightsType EvaluationRightsType { get; set; }
        public string AppraisalCondition { get; set; }
        //
        public string SurveyorName { get; set; }
        public string SurveyDescription { get; set; }
        //
        // 以下為實體檔案預留位置
        //
        // 建物謄本檔案路徑
        // 現勘照片路徑
        public string TranscriptPath { get; set; }
        public string PhotoPath { get; set; }
    }

    public class ParkSurveySheetForm : ParkSurveyDataSheet
    {
        public IFormFile TranscriptFile { get; set; }
        public List<IFormFile> SurveyPhoto { get; set; }
        public string guid { get; set; }
    }
}
