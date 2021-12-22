using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace vpmc_backend.Models
{
    public class WebApiContext : DbContext
    {
        public WebApiContext(DbContextOptions<WebApiContext> options) : base(options) {}


        // 通用Table (適用於土地、建物、車位)
        public DbSet<BuildingAssetType> Building_AssetType { get; set; }
        public DbSet<LandAssetType> Land_AssetType { get; set; }
        public DbSet<ParkAssetType> Park_AssetType { get; set; }
        //
        public DbSet<BuildingLandRightsStatus> Building_LandRightsStatus { get; set; }
        public DbSet<LandLandRightsStatus> Land_LandRightsStatus { get; set; }
        public DbSet<ParkLandRightsStatus> Park_LandRightsStatus { get; set; }
        //
        public DbSet<BuildingAppraisalObject> Building_AppraisalObject { get; set; }
        public DbSet<LandAppraisalObject> Land_AppraisalObject { get; set; }
        public DbSet<ParkAppraisalObject> Park_AppraisalObject { get; set; }
        //
        public DbSet<BuildingPriceType> Building_PriceType { get; set; }
        public DbSet<LandPriceType> Land_PriceType { get; set; }
        public DbSet<ParkPriceType> Park_PriceType { get; set; }
        //
        public DbSet<BuildingEvaluationRightsType> Building_EvaluationRightsType { get; set; }
        public DbSet<LandEvaluationRightsType> Land_EvaluationRightsType { get; set; }
        public DbSet<ParkEvaluationRightsType> Park_EvaluationRightsType { get; set; }



        // 特定Table (適用於建物、車位)
        public DbSet<BuildingBuildingRightsStatus> Building_BuildingRightsStatus { get; set; }
        public DbSet<ParkBuildingRightsStatus> Park_BuildingRightsStatus { get; set; }
        //
        public DbSet<BuildingBuildingUsage> Building_BuildingUsage { get; set; }
        public DbSet<ParkBuildingUsage> Park_BuildingUsage { get; set; }
        //
        public DbSet<BuildingBuildingStructure> Building_BuildingStructure { get; set; }
        public DbSet<ParkBuildingStructure> Park_BuildingStructure { get; set; }



        // 特定Table (適用於車位)
        public DbSet<ParkType> ParkType { get; set; }
        public DbSet<ParkMethod> ParkMethod { get; set; }
        public DbSet<ParkAssignMethod> ParkAssignMethod { get; set; }



        // 土地現勘資料表
        public DbSet<LandSurveyDataSheet> LandSurveyDataSheet { get; set; }
        
        // 建物現勘資料表
        public DbSet<BuildingSurveyDataSheet> BuildingSurveyDataSheet { get; set; }

        // 車位現勘資料表
        public DbSet<ParkSurveyDataSheet> ParkSurveyDataSheet { get; set; }

        //實價登錄交易資料表
        public DbSet<Deal> Deal { get; set; }
        public DbSet<Deal_Manage> Deal_Manage { get; set; }
    }
}
