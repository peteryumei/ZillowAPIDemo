﻿using System;
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
            IZillowService zillowService = new ZillowService();
            try { 
                SearchResult resultModel = zillowService.HomeSearch(model);
                if (resultModel.returnCode == "0")
                    return View("SearchResult", resultModel);
                else
                    return View("ErrorPage", resultModel);
            }
             catch (Exception ex)
            {
                SearchResult result = new SearchResult();
                result.returnCode = "-1";
                result.returnMessgae = "Fatal Error: " + ex.Message;
                return View("ErrorPage", result);
            }
        }

        [HttpGet]
        public JsonResult HomeSearchJSON()
        {
            string querystring = Request.QueryString.Value;
           
            IZillowService zillowService = new ZillowService();
            string result = zillowService.HomeSearchJSON(querystring);
            return Json(result);
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
