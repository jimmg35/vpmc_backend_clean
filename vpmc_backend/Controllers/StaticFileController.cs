using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Diagnostics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace vpmc_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaticFileController : ControllerBase
    {
        public static IWebHostEnvironment _environment;
        private string _staticFile_path;
        private List<string> _item;

        public StaticFileController(IWebHostEnvironment environment)
        {
            _environment = environment;
            _staticFile_path = _environment.WebRootPath + "\\staticFiles\\";
            string[] items = { "GeneralLaw", "Bulletin" };
            _item = new List<string>(items);
        }


        // GET: api/<StaticFileController>
        [HttpGet("getFiles")]
        public IActionResult Get(string item)
        {
            if (!_item.Contains(item))
            {
                return StatusCode(422);
            }


            var output = new List<Dictionary<string, string>>();
            string dir = _staticFile_path + item;
            string[] filesPath = Directory.GetFiles(dir);
            foreach(string path in filesPath)
            {
                string fileName = Path.GetFileName(path);
                Dictionary<string, string> chunk = new Dictionary<string, string>();
                chunk.Add("renderName", fileName);
                chunk.Add("serverRoute", "/staticFiles/" + item + "/" + fileName);
                output.Add(chunk);
            }
            return StatusCode(200, output);
        }


    }
}
