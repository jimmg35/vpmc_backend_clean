using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vpmc_backend.Models
{
    public class ParkType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public IList<ParkSurveyDataSheet> SurveyDataSheets { get; set; }
    }
}
