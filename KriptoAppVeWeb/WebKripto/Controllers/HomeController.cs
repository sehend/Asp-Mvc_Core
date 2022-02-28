using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebKripto.ApiServis;
using WebKripto.Models;

namespace WebKripto.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

    




        private readonly KriptoApiServis _categoryApiServis;


        public HomeController(KriptoApiServis categoryApiServis)
        {


            

            _categoryApiServis = categoryApiServis;

        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Index1()
        {
            var categpries = await _categoryApiServis.GetAllAsync();


            return View( categpries );
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
