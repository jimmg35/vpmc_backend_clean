using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace vpmc_backend.Models
{
    public class Administrative_Area
    {
        [Key]
        public int OID { get; set; }
        public string CountyName { get; set; }
        public string TownName { get; set; }
        public string VillName { get; set; }
    }
}
