﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {

        static private Dictionary<string,string> Cheeses = new Dictionary<string, string>();

        // GET: /<controller>/
        public IActionResult Index() {

            ViewBag.cheeses = Cheeses;

            return View();
        }

        public IActionResult Add() {
            return View(); 
        }

        [Route("/Cheese/Add")]
        [HttpPost]
        public IActionResult NewCheese(string name, string description) {
            // Add new cheese and description to existing cheeses
            Cheeses.Add(name, description);

            return Redirect("/Cheese");

        }
    }
}