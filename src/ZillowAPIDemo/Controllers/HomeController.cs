using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZillowAPIDemo.Models;
using ZillowAPIDemo.Service;

namespace ZillowAPIDemo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Index")]
        public IActionResult IndexPost(Models.HomeAddress model)
        {

            string address = model.StreetAddress;
            IZillowService zillowService = new ZillowService();
            SearchResult resultResultModel = zillowService.HomeSearch(model);
            return View("SearchResult", resultResultModel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Zillow API Demo";

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
