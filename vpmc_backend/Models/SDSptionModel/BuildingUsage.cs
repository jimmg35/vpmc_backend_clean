using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vpmc_backend.Models
{
    public class BuildingBuildingUsage
    {
        public int Id { get; set; }
        public string Usage { get; set; }
        public IList<BuildingSurveyDataSheet> SurveyDataSheets { get; set; }
    }

    public class ParkBuildingUsage
    {
        public int Id { get; set; }
        public string Usage { get; set; }
        public IList<ParkSurveyDataSheet> SurveyDataSheets { get; set; }
    }
}
