using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vpmc_backend.Models
{
    public class BuildingEvaluationRightsType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public IList<BuildingSurveyDataSheet> SurveyDataSheets { get; set; }
    }

    public class LandEvaluationRightsType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public IList<LandSurveyDataSheet> SurveyDataSheets { get; set; }
    }

    public class ParkEvaluationRightsType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public IList<ParkSurveyDataSheet> SurveyDataSheets { get; set; }
    }

}
