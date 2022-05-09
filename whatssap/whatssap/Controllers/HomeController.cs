using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WhatsAppApi;
using whatssap.Models;

namespace whatssap.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            {

                return View();
            }  
        }

        [HttpPost]
        public IActionResult Index(string to1 , string msg1)
        {
            {
                string from = "9199876543210"; //(Enter Your Mobile Number) 
                string to = to1;
                string msg = msg1;
                WhatsApp wa = new WhatsApp(from, "WhatsAppPassword", "NickName", false, false);
                wa.OnConnectSuccess += () =>
                {

                    wa.OnLoginSuccess += (phonenumber, data) =>
                    {
                        wa.SendMessage(to, msg);

                    };
                    wa.OnLoginFailed += (data) =>
                    {

                    };

                    wa.Login();
                };
                wa.OnConnectFailed += (Exception) =>
                {

                };
            }


            return View();
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
