using System.Diagnostics;
using Klinik_WEBUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Klinik_WEBUI.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

       
    }
}
