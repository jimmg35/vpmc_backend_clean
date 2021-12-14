using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vpmc_backend.Models
{
    public class BuildingLandRightsStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public IList<BuildingSurveyDataSheet> SurveyDataSheets { get; set; }
    }

    public class LandLandRightsStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public IList<LandSurveyDataSheet> SurveyDataSheets { get; set; }
    }

    public class ParkLandRightsStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public IList<ParkSurveyDataSheet> SurveyDataSheets { get; set; }
    }
}
