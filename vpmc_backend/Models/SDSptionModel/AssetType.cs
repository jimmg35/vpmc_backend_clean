using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vpmc_backend.Models
{
    public class BuildingAssetType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public IList<BuildingSurveyDataSheet> SurveyDataSheet { get; set; }
    }

    public class LandAssetType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public IList<LandSurveyDataSheet> SurveyDataSheet { get; set; }
    }

    public class ParkAssetType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public IList<ParkSurveyDataSheet> SurveyDataSheet { get; set; }
    }
}
