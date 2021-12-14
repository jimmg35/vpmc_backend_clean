using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vpmc_backend.Models
{
    public class BuildingAppraisalObject
    {
        public int Id { get; set; }
        public string Object { get; set; }
        public IList<BuildingSurveyDataSheet> SurveyDataSheet { get; set; }
    }

    public class LandAppraisalObject
    {
        public int Id { get; set; }
        public string Object { get; set; }
        public IList<LandSurveyDataSheet> SurveyDataSheet { get; set; }
    }

    public class ParkAppraisalObject
    {
        public int Id { get; set; }
        public string Object { get; set; }
        public IList<ParkSurveyDataSheet> SurveyDataSheet { get; set; }
    }
}
