using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vpmc_backend.Models
{
    public class BuildingBuildingStructure
    {
        public int Id { get; set; }
        public string Structure { get; set; }
        public IList<BuildingSurveyDataSheet> SurveyDataSheet { get; set; }
    }

    public class ParkBuildingStructure
    {
        public int Id { get; set; }
        public string Structure { get; set; }
        public IList<ParkSurveyDataSheet> SurveyDataSheet { get; set; }
    }
}
