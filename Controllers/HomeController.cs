using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PenaP4.Models;
using PenaP4.Models.Resume;

namespace PenaP4.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Blog()
        {
            
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Resume()
        {
            var resumeViewModels = new List<ResumeViewModel>
            {   new ResumeViewModel {Preamble ="A beginning programmer only trying to get better",
            }
                
            
        };

            return View(resumeViewModels);
        }
        public IActionResult PayPalBasicPayment()
        {
            ViewBag.Message = "PayPal Basic Payment";
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
