using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ChiefEntertainment.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [Route("Services")]
        public IActionResult Services()
        {
            return View();
        }


        [AllowAnonymous]
        [Route("Testimonials")]
        public IActionResult Testimonials()
        {
            return View();
        }


        [AllowAnonymous]
        [Route("Calendar")]
        public IActionResult Calendar()
        {
            return View();
        }


        [AllowAnonymous]
        [Route("About")]
        public IActionResult About()
        {
            return View();
        }


        [AllowAnonymous]
        [Route("Booking")]
        public IActionResult Booking()
        {
            return View();
        }


        [AllowAnonymous]
        [Route("Contact")]
        public IActionResult Contact()
        {
            return View();
        }
    }
}