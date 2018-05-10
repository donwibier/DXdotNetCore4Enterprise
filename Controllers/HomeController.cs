using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DXdotNetCore4Enterprise.Models;
using DXdotNETCore4Enterprise.Models;

namespace DXdotNetCore4Enterprise.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = StaticHomeData.Data;
            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
