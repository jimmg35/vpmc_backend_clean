using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vpmc_backend.Models
{
    public class LandSurveyDataSheet
    {
        public string Id { get; set; } // Primary Key
        public string UserId { get; set; }
        //
        public int AssetTypeId { get; set; }
        public LandAssetType AssetType { get; set; }
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
        public int LandRightsStatusId { get; set; }
        public LandLandRightsStatus LandRightsStatus { get; set; }
        public string LandRightsHolding { get; set; }
        public string OtherRights { get; set; }
        //
        public string LandUses { get; set; }
        public double BuildingCoverageRatio { get; set; }
        public double FloorAreaRatio { get; set; }
        //
        public DateTime InspectionDate { get; set; }
        public DateTime ValueOpinionDate { get; set; }
        //
        public int AppraisalObjectId { get; set; }
        public LandAppraisalObject AppraisalObject { get; set; }
        public string AppraisalDescription { get; set; }
        //
        public int PriceTypeId { get; set; }
        public LandPriceType PriceType { get; set; }
        public int EvaluationRightsTypeId { get; set; }
        public LandEvaluationRightsType EvaluationRightsType { get; set; }
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

    public class LandSurveySheetForm : LandSurveyDataSheet
    {
        public IFormFile TranscriptFile { get; set; }
        public List<IFormFile> SurveyPhoto { get; set; }
        public string guid { get; set; }
        public LandSurveySheetForm convert(LandSurveyDataSheet sheet)
        {
            LandSurveySheetForm form = new LandSurveySheetForm();

            form.AppraisalCondition = sheet.AppraisalCondition;
            form.AppraisalDescription = sheet.AppraisalDescription;
            form.AppraisalObject = sheet.AppraisalObject;
            form.AppraisalObjectId = sheet.AppraisalObjectId;
            form.AssetType = sheet.AssetType;
            form.AssetTypeId = sheet.AssetTypeId;
            form.BuildAddress = sheet.BuildAddress;
            form.BuildAddressCounty = sheet.BuildAddressCounty;
            form.BuildAddressVillage = sheet.BuildAddressVillage;
            form.BuildingCoverageRatio = sheet.BuildingCoverageRatio;
            form.BuildMarkCode = sheet.BuildMarkCode;
            form.BuildMarkCounty = sheet.BuildMarkCounty;
            form.BuildMarkName = sheet.BuildMarkName;
            form.BuildMarkVillage = sheet.BuildMarkVillage;
            form.EvaluationRightsType = sheet.EvaluationRightsType;
            form.EvaluationRightsTypeId = sheet.EvaluationRightsTypeId;
            form.FloorAreaRatio = sheet.FloorAreaRatio;
            form.Id = sheet.Id;
            form.InspectionDate = sheet.InspectionDate;
            form.LandArea = sheet.LandArea;
            form.LandMarkCode = sheet.LandMarkCode;
            form.LandMarkCounty = sheet.LandMarkCounty;
            form.LandMarkName = sheet.LandMarkName;
            form.LandMarkVillage = sheet.LandMarkVillage;
            form.LandRightsHolding = sheet.LandRightsHolding;
            form.LandRightsOwner = sheet.LandRightsOwner;
            form.LandRightsStatus = sheet.LandRightsStatus;
            form.LandRightsStatusId = sheet.LandRightsStatusId;
            form.LandUses = sheet.LandUses;
            form.OtherRights = sheet.OtherRights;
            form.PhotoPath = sheet.PhotoPath;
            form.PriceType = sheet.PriceType;
            form.PriceTypeId = sheet.PriceTypeId;
            form.SurveyDescription = sheet.SurveyDescription;
            form.SurveyorName = sheet.SurveyorName;
            form.TranscriptPath = sheet.TranscriptPath;
            form.UserId = sheet.UserId;

            return form;
        }
    }
}
