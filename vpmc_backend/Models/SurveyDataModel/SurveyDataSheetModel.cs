using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace vpmc_backend.Models
{
    public interface ISurveyDataSheetModel
    {
        IFormFile TranscriptFile { get; set; }
        List<IFormFile> SurveyPhoto { get; set; }
    }

    public class BuildingSurveyDataSheetModel : ISurveyDataSheetModel
    {
        public IFormFile TranscriptFile { get; set; }
        public List<IFormFile> SurveyPhoto { get; set; }

        //
        // 以下為現勘資料表資料
        //
        public string UserId { get; set; }
        //
        public int AssetType { get; set; }
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
        public double LandArea { get; set; }
        public double BuildingArea { get; set; }
        //
        public string LandRightsOwner { get; set; }
        public int LandRightsStatus { get; set; }
        public string LandRightsHolding { get; set; }
        public string BuildingRightsOwner { get; set; }
        public int BuildingRightsStatus { get; set; }
        public string BuildingRightsHolding { get; set; }
        public string OtherRights { get; set; }
        //
        public string LandUses { get; set; }
        public double BuildingCoverageRatio { get; set; }
        public double FloorAreaRatio { get; set; }
        public int BuildingUsage { get; set; }
        public int BuildingStructure { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BuildingFinishDate { get; set; }
        public int BuildingUpFloor { get; set; }
        public int BuildingDownFloor { get; set; }
        public int SurveyFloor { get; set; }
        //
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime InspectionDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ValueOpinionDate { get; set; }
        //
        public int AppraisalObject { get; set; }
        public string AppraisalDescription { get; set; }
        //
        public int PriceType { get; set; }
        public int EvaluationRightsType { get; set; }
        public string AppraisalCondition { get; set; }
        //
        public string SurveyorName { get; set; }
        public string SurveyDescription { get; set; }
    }

    public class LandSurveyDataSheetModel : ISurveyDataSheetModel
    {
        public IFormFile TranscriptFile { get; set; }
        public List<IFormFile> SurveyPhoto { get; set; }

        //
        // 以下為現勘資料表資料
        //
        public string Id { get; set; } // Primary Key
        public string UserId { get; set; }
        //
        public int AssetType { get; set; }
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
        public double LandArea { get; set; }
        //
        public string LandRightsOwner { get; set; }
        public int LandRightsStatus { get; set; }
        public string LandRightsHolding { get; set; }
        public string OtherRights { get; set; }
        //
        public string LandUses { get; set; }
        public double BuildingCoverageRatio { get; set; }
        public double FloorAreaRatio { get; set; }
        //
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime InspectionDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ValueOpinionDate { get; set; }
        //
        public int AppraisalObject { get; set; }
        public string AppraisalDescription { get; set; }
        //
        public int PriceType { get; set; }
        public int EvaluationRightsType { get; set; }
        public string AppraisalCondition { get; set; }
        //
        public string SurveyorName { get; set; }
        public string SurveyDescription { get; set; }
    }

    public class ParkSurveyDataSheetModel : ISurveyDataSheetModel
    {
        public IFormFile TranscriptFile { get; set; }
        public List<IFormFile> SurveyPhoto { get; set; }

        //
        // 以下為現勘資料表資料
        //
        public string Id { get; set; } // Primary Key
        public string UserId { get; set; }
        //
        public int AssetTypeId { get; set; }
        public int AssetType { get; set; }
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
        public int ParkType { get; set; }
        public int ParkMethodId { get; set; }
        public int ParkMethod { get; set; }
        //
        public string LandRightsOwner { get; set; }
        public int LandRightsStatusId { get; set; }
        public int LandRightsStatus { get; set; }
        public string LandRightsHolding { get; set; }
        public string BuildingRightsOwner { get; set; }
        public int BuildingRightsStatusId { get; set; }
        public int BuildingRightsStatus { get; set; }
        public string BuildingRightsHolding { get; set; }
        public string OtherRights { get; set; }
        public int AssignMethodId { get; set; }
        public int AssignMethod { get; set; }
        //
        public string LandUses { get; set; }
        public double BuildingCoverageRatio { get; set; }
        public double FloorAreaRatio { get; set; }
        public int BuildingUsageId { get; set; }
        public int BuildingUsage { get; set; }
        public int BuildingStructureId { get; set; }
        public int BuildingStructure { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BuildingFinishDate { get; set; }
        public int BuildingUpFloor { get; set; }
        public int BuildingDownFloor { get; set; }
        public int SurveyFloor { get; set; }
        public double ParkWidth { get; set; }
        public double ParkHeight { get; set; }
        public bool AllowSuv { get; set; }
        //
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime InspectionDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ValueOpinionDate { get; set; }
        //
        public int AppraisalObjectId { get; set; }
        public int AppraisalObject { get; set; }
        public string AppraisalDescription { get; set; }
        //
        public int PriceTypeId { get; set; }
        public int PriceType { get; set; }
        public int EvaluationRightsTypeId { get; set; }
        public int EvaluationRightsType { get; set; }
        public string AppraisalCondition { get; set; }
        //
        public string SurveyorName { get; set; }
        public string SurveyDescription { get; set; }
    }
}
