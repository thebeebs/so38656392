using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using so38656392.Models;

namespace so38656392.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // I'm using ASP.net Core MVC with Razor. 
            // My ViewModel contains string OriginalText and 
            // List<string> KeyPhrases. I already have a CSS class 
            // called highlight which will apply the yellow 
            // colour as a background-color.

            var vm = new ResultViewModel();
            vm.OriginalText = "I wonder is this Cognitive Services API stuff actually works? Lets hope so";
            vm.KeyPhrases = new List<String>();
            vm.KeyPhrases.Add("API stuff");
            vm.KeyPhrases.Add("works");
            vm.KeyPhrases.Add("Lets");

            return View(vm);
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
            return View();
        }
    }
}
