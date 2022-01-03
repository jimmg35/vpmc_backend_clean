using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vpmc_backend.Models;

namespace vpmc_backend.ViewModel
{
    public class BuildingViewModel
    {
        public SelectList BuildingStructureList = new SelectList(new List<SelectListItem>
        {
            new SelectListItem{ Text = "住宅用", Value = "1"},
            new SelectListItem{ Text = "商業用", Value = "2"},
            new SelectListItem{ Text = "工業用", Value = "3"},
            new SelectListItem{ Text = "廠辦使用", Value = "4"},
            new SelectListItem{ Text = "住辦混合", Value = "5"},
            new SelectListItem{ Text = "住商辦混合", Value = "6"},
            new SelectListItem{ Text = "其他", Value = "7"},
        },"Value","Text");
        
    }

}
