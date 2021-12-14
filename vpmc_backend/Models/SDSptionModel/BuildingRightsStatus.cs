using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vpmc_backend.Models
{
    public class BuildingBuildingRightsStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public IList<BuildingSurveyDataSheet> SurveyDataSheet { get; set; }
    }

    public class ParkBuildingRightsStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public IList<ParkSurveyDataSheet> SurveyDataSheet { get; set; }
    }
}
