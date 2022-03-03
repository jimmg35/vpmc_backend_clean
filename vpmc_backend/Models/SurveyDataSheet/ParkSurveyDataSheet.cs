using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace vpmc_backend.Models
{
    public class ParkSurveyDataSheet
    {
        public string Id { get; set; } // Primary Key
        public string UserId { get; set; }
        //
        [DisplayName("資產類型")]
        public int AssetTypeId { get; set; }
        public ParkAssetType AssetType { get; set; }
        //
        [DisplayName("土地標示（縣市）")]
        public string LandMarkCounty { get; set; }
        //
        [DisplayName("土地標示（鄉鎮市區）")]
        public string LandMarkVillage { get; set; }
        //
        [DisplayName("土地標示（段）")]
        public string LandMarkName { get; set; }
        //
        [DisplayName("土地標示（小段）")]
        public string LandMarkCode { get; set; }
        //
        [DisplayName("建物標示（縣市）")]
        public string BuildMarkCounty { get; set; }
        //
        [DisplayName("建物標示（鄉鎮市區）")]
        public string BuildMarkVillage { get; set; }
        //
        [DisplayName("建物標示（地址）")]
        public string BuildMarkName { get; set; }
        //
        [DisplayName("建物標示（小段）")]
        public string BuildMarkCode { get; set; }
        //
        [DisplayName("建物門牌（縣市）")]
        public string BuildAddressCounty { get; set; }
        //
        [DisplayName("建物門牌（鄉鎮市區）")]
        public string BuildAddressVillage { get; set; }
        //
        [DisplayName("建物門牌（地址）")]
        public string BuildAddress { get; set; }
        //
        [DisplayName("車位面積")]
        public double ParkArea { get; set; }
        //
        [DisplayName("車位種類")]
        public int ParkTypeId { get; set; }
        public ParkType ParkType { get; set; }
        //
        [DisplayName("車位形式")]
        public int ParkMethodId { get; set; }
        public ParkMethod ParkMethod { get; set; }
        //
        [DisplayName("土地所有權人")]
        public string LandRightsOwner { get; set; }
        //
        [DisplayName("權利範圍（土地）")]
        public int LandRightsStatusId { get; set; }
        public ParkLandRightsStatus LandRightsStatus { get; set; }
        //
        [DisplayName("土地所有狀態")]
        public string LandRightsHolding { get; set; }
        //
        [DisplayName("建物所有權人")]
        public string BuildingRightsOwner { get; set; }
        //
        [DisplayName("權利範圍（建物）")]
        public int BuildingRightsStatusId { get; set; }
        public ParkBuildingRightsStatus BuildingRightsStatus { get; set; }
        //
        [DisplayName("建物所有狀態")]
        public string BuildingRightsHolding { get; set; }
        //
        [DisplayName("他項權利")]
        public string OtherRights { get; set; }
        //
        [DisplayName("登記方式")]
        public int AssignMethodId { get; set; }
        public ParkAssignMethod AssignMethod { get; set; }
        //
        [DisplayName("使用分區")]
        public string LandUses { get; set; }
        //
        [DisplayName("法定建蔽率")]
        public double BuildingCoverageRatio { get; set; }
        //
        [DisplayName("法定容積率")]
        public double FloorAreaRatio { get; set; }
        //
        [DisplayName("建物法定用途")]
        public int BuildingUsageId { get; set; }
        public ParkBuildingUsage BuildingUsage { get; set; }
        //
        [DisplayName("建物建造")]
        public int BuildingStructureId { get; set; }
        public ParkBuildingStructure BuildingStructure { get; set; }
        //
        [DisplayName("建造完成日")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BuildingFinishDate { get; set; }
        //
        [DisplayName("建物地上量體")]
        public int BuildingUpFloor { get; set; }
        //
        [DisplayName("建物地下量體")]
        public int BuildingDownFloor { get; set; }
        //
        [DisplayName("勘估標的座落樓層")]
        public int SurveyFloor { get; set; }
        //
        [DisplayName("入口車寬")]
        public double ParkWidth { get; set; }
        //
        [DisplayName("入口車高")]
        public double ParkHeight { get; set; }
        //
        [DisplayName("可停休旅車為")]
        public bool AllowSuv { get; set; }
        //
        [DisplayName("勘查日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime InspectionDate { get; set; }
        //
        [DisplayName("價格日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ValueOpinionDate { get; set; }
        //
        [DisplayName("估價目的")]
        public int AppraisalObjectId { get; set; }
        public ParkAppraisalObject AppraisalObject { get; set; }
        //
        [DisplayName("估價目的描述")]
        public string AppraisalDescription { get; set; }
        //
        [DisplayName("價格種類")]
        public int PriceTypeId { get; set; }
        public ParkPriceType PriceType { get; set; }
        //
        [DisplayName("評價權利種類")]
        public int EvaluationRightsTypeId { get; set; }
        public ParkEvaluationRightsType EvaluationRightsType { get; set; }
        //
        [DisplayName("評價條件")]
        public string AppraisalCondition { get; set; }
        //
        [DisplayName("勘領人姓名")]
        public string SurveyorName { get; set; }
        //
        [DisplayName("勘領說明事項")]
        public string SurveyDescription { get; set; }
        //
        // 以下為實體檔案預留位置
        //
        // 建物謄本檔案路徑
        // 現勘照片路徑
        [DisplayName("標的謄本")]
        public string TranscriptPath { get; set; }
        [DisplayName("現勘照片")]
        public string PhotoPath { get; set; }
    }

    public class ParkSurveySheetForm : ParkSurveyDataSheet
    {
        public IFormFile TranscriptFile { get; set; }
        public List<IFormFile> SurveyPhoto { get; set; }
        public string guid { get; set; }

        public ParkSurveySheetForm convert(ParkSurveyDataSheet sheet)
        {
            ParkSurveySheetForm form = new ParkSurveySheetForm();
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
            form.BuildingDownFloor = sheet.BuildingDownFloor;
            form.BuildingFinishDate = sheet.BuildingFinishDate;
            form.BuildingRightsHolding = sheet.BuildingRightsHolding;
            form.BuildingRightsOwner = sheet.BuildingRightsOwner;
            form.BuildingRightsStatus = sheet.BuildingRightsStatus;
            form.BuildingRightsStatusId = sheet.BuildingRightsStatusId;
            form.BuildingStructure = sheet.BuildingStructure;
            form.BuildingStructureId = sheet.BuildingStructureId;
            form.BuildingUpFloor = sheet.BuildingUpFloor;
            form.BuildingUsage = sheet.BuildingUsage;
            form.BuildingUsageId = sheet.BuildingUsageId;
            form.BuildMarkCode = sheet.BuildMarkCode;
            form.BuildMarkCounty = sheet.BuildMarkCounty;
            form.BuildMarkName = sheet.BuildMarkName;
            form.BuildMarkVillage = sheet.BuildMarkVillage;
            form.EvaluationRightsType = sheet.EvaluationRightsType;
            form.EvaluationRightsTypeId = sheet.EvaluationRightsTypeId;
            form.FloorAreaRatio = sheet.FloorAreaRatio;
            form.Id = sheet.Id;
            form.InspectionDate = sheet.InspectionDate;
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
            form.SurveyFloor = sheet.SurveyFloor;
            form.SurveyorName = sheet.SurveyorName;
            form.TranscriptPath = sheet.TranscriptPath;
            form.UserId = sheet.UserId;
            form.AllowSuv = sheet.AllowSuv;
            form.ParkArea = sheet.ParkArea;
            form.ParkHeight = sheet.ParkHeight;
            form.ParkMethod = sheet.ParkMethod;
            form.ParkMethodId = sheet.ParkMethodId;
            form.ParkType = sheet.ParkType;
            form.ParkTypeId = sheet.ParkTypeId;
            form.ParkWidth = sheet.ParkWidth;

            return form;
        }
    }
}
