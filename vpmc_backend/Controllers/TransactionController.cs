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
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace vpmc_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly WebApiContext _context;

        public TransactionController(WebApiContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        [HttpGet("getCommittee")]
        public IEnumerable<string> Get(string county, string town)
        {
            var result = from deal in _context.Deal_Manage where deal.ConstructionParcel.Contains(county + town) select deal.ManageName;
            return result.Distinct().ToList();
        }
    }
}
