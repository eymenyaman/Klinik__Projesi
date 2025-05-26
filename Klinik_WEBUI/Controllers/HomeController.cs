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

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Feature()
        {
            return View();
        }

        public IActionResult Appointment()
        {
            return View();
        }

        public IActionResult Service()
        {
            return View();
        }

        public IActionResult Team()
        {
            return View();
        }

        public IActionResult Testimonial()
        {
            return View(); 
        }

    }
}
