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
using System.Text.Json;
using System.Text.Json.Serialization;
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

        [AllowAnonymous]
        [HttpGet("getCommitteeHistory")]
        public List<CommitteeHistory> Get(string committeeName)
        {
            List<CommitteeHistory> result = (
                from deal in _context.Deal_Manage 
                where deal.ManageName == committeeName 
                select new CommitteeHistory{
                        transactionDate = deal.TransactionDate,
                        transferLevel = deal.ParsedShiftingLevel,
                        units = deal.TotalFloorArea,
                        totalPrice = deal.TotalPrice,
                        unitPrice = deal.UnitPrice,
                        bathNumber = deal.BathNumber,
                        bedNumber = deal.BedNumber,
                        hallNumber = deal.HallNumber
                }
                ).ToList();
            return result;
        }

        [AllowAnonymous]
        [HttpGet("getRegionHistory")]
        public Dictionary<string, Dictionary<string, Dictionary<string, double>>> GetRegion(string county,string town)
        {
            var records = _context.Deal_Manage
                .Where(x => x.County == county && x.Town == town)
                .GroupBy(
                    x => new
                    {
                        state = x.BuildingState,
                        year = x.CompletionDate.Substring(0,4)
                    })
                .Select(y => new
                    {
                        state = y.Key.state,
                        year = int.Parse(y.Key.year) - 1911,
                        counts = y.Count(),
                        totalPrice = y.Average(x => x.TotalPrice),
                        unitPrice = y.Average(x => x.UnitPrice),
                        age = (DateTime.Now.Year - 1911) - (int.Parse(y.Key.year)-1911)
                    });

            var results = new Dictionary<string, Dictionary<string, Dictionary<string, double>>> ();

            foreach (var record in records)
            {
                if (!results.ContainsKey(record.state))
                {
                    results.Add(record.state, new Dictionary<string, Dictionary<string, double>>
                    {
                        ["counts"] = new Dictionary<string, double>(),
                        ["totalPrice"] = new Dictionary<string, double>(),
                        ["unitPrice"] = new Dictionary<string, double>(),
                        ["age"] = new Dictionary<string, double>()
                    });
                }

                results[record.state]["counts"].Add(record.year.ToString(),record.counts);
                results[record.state]["totalPrice"].Add(record.year.ToString(), (double)record.totalPrice);
                results[record.state]["unitPrice"].Add(record.year.ToString(), (double)record.unitPrice);
                results[record.state]["age"].Add(record.year.ToString(), record.age);
            }

            //var options = new JsonSerializerOptions { WriteIndented = true };
            //string jsonString = JsonSerializer.Serialize(results, options);

            return results;
        }
    }

    public class CommitteeHistory
    {
        public string transactionDate { get; set; }
        public int? transferLevel { get; set; }
        public string units { get; set; }
        public long? totalPrice { get; set; }
        public float? unitPrice { get; set; }
        public long? bathNumber { get; set; }
        public long? bedNumber { get; set; }
        public long? hallNumber { get; set; }
    }
}
