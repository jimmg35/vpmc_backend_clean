using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vpmc_backend.Models
{
    public class ParkAssignMethod
    {
        public int Id { get; set; }
        public string Method { get; set; }
        public IList<ParkSurveyDataSheet> SurveyDataSheet { get; set; }
    }
}
