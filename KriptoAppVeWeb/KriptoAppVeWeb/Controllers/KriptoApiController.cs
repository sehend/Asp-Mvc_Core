using KriptoAppVeWeb.Models;
using KriptoCore.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace KriptoAppVeWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KriptoApiController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<KriptoApiController> _logger;

        public KriptoApiController(ILogger<KriptoApiController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<sehend>> Get()
        {
            sehend result;

            try
            {
                using (var client = new HttpClient())
                {
                    string url = string.Format("https://api.genelpara.com/embed/kripto.json");
                    var response = client.GetAsync(url).Result;

                    string responseAsString = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<sehend>(responseAsString);
                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

            return Ok(result);
        }
    }





}