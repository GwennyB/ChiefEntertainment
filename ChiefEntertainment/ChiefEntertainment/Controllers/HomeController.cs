using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChiefEntertainment.Models;
using ChiefEntertainment.Models.ViewModels;
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

        [AllowAnonymous]
        [Route("SubmitContact")]
        public async Task<IActionResult> SubmitContact(ContactViewModel vm)
        {
                // build email
                Email message = new Email()
                {
                    Recipient = User.Identity.Name,
                    ConfigSet = "",
                    Subject = "Message received on chief-entertainment.net",
                    BodyHtml = $@"<html>
                                <head></head>
                                <body>
                                  <h3>Message from: {vm.Name}</h3>
                                  <h3>Contact email: {vm.Email}</h3>
                                  <h3>Contact phone: {vm.Phone}</h3>
                                  <h3>Message:</h3>
                                  <p>{vm.Message}</p>
                                </body>
                                </html>",
                };

                // send email (3 tries)
                int counter = 0;
                bool emailStatus = false;
                while (emailStatus == false && counter < 3)
                {
                    emailStatus = await Email.Send(message);
                }

                if (emailStatus == false)
                {
                    ModelState.AddModelError(string.Empty, "Message failed. Please try again.");
                    return View("Contact", vm);
                }
                return RedirectToRoute("");
        }
    }
}