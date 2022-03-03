using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using vpmc_backend.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Data;

namespace vpmc_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstimateController : ControllerBase
    {
        private readonly WebApiContext _context;

        public EstimateController(WebApiContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        [HttpGet("compare")]
        public List<Deal_Manage> Compare(string county, string town, string transactionInterval, string assertType, string totalUnitsInterval, int age)
        {
            string[] transactionQuery = transactionInterval.Split("-");
            string[] totalUnitQuery = totalUnitsInterval.Split("-");

            var query = _context.Deal_Manage
                .Where(x => x.County == county && x.Town == town && x.BuildingState.Contains(assertType))
                .Select(x => new
                {
                    x,
                    area = x.BuildingShiftingArea,
                    date = DateTime.Parse(x.CompletionDate),
                    age = DateTime.Now.Year - DateTime.Parse(x.CompletionDate).Year
                }).ToList();

            var results = query
                .Where(x => x.date >= DateTime.Parse(transactionQuery[0]) && x.date < DateTime.Parse(transactionQuery[1]) && x.area >= double.Parse(totalUnitQuery[0]) && x.area < double.Parse(totalUnitQuery[1]) && x.age <= age)
                .Select(x => x.x)
                .ToList();


            return results;
        }

        public class compareResults
        {
            public List<string> transactionSerialNumber { get; set; }

            public compareResults(List<string> list)
            {
                this.transactionSerialNumber = list;
            }

        }
    }
}
