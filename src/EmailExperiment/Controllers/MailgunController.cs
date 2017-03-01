using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmailExperiment.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace EmailExperiment.Controllers
{
    public class MailgunController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(string recipient, string subject, string text)
        {
            Email.SendMailgunMessage(recipient, subject, text);
            return Content("Message sent");
        }
    }
}
