using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using vpmc_backend.Models;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace vpmc_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilityController : ControllerBase
    {
        private readonly WebApiContext _context;

        public UtilityController(WebApiContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        [HttpGet("getCounty")]
        public IEnumerable<string> Get()
        {
            return _context.Administrative_Area.Select(row => row.CountyName).Distinct().ToList();
        }

        [AllowAnonymous]
        [HttpGet("getTown")]
        public IEnumerable<string> Get(string county)
        {
            return _context.Administrative_Area
                .Where(row => row.CountyName == county)
                .Select(row => row.TownName)
                .Distinct()
                .ToList();
        }

        [AllowAnonymous]
        [HttpGet("getVillage")]
        public IEnumerable<string> Get(string county, string town)
        {
            return _context.Administrative_Area
                .Where(row => row.CountyName == county && row.TownName == town)
                .Select(row => row.VillName)
                .Distinct()
                .ToList();
        }

    }
}
