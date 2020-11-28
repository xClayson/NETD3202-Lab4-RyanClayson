/*
 * Name: Ryan Clayson
 * Date: 11/20/2020
 * Purpose: HomeController that calls views of various pages
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NETD3202_Lab4_RyanClayson.Models;

namespace NETD3202_Lab4_RyanClayson.Controllers
{
    public class HomeController : Controller
    {
        public static List<Textbook> booklist = new List<Textbook>();

        public IActionResult Index()
        {
            Textbook message = new Textbook();
            return View(message);
        }

        [HttpGet]
        public IActionResult Appraise()
        {
            return View();     
        }

        [HttpPost]
        public IActionResult Appraise(Textbook model)
        {
            //Checks to see if user has inputed in all required feilds
            if (ModelState.IsValid)
            {
                booklist.Add(new Textbook(model.title, model.isbn, model.version, model.price, model.condition));
                //Sets message to To.String
                ViewData["Message"] = model.ToString();
                //Redirects to View Appraisal Page
                return View("YourAppraisal", model);
            }
            //Invalid. User did not enter inout in one or more fields
            else
            {
                return View("Fail");
            }
        }
        public IActionResult ViewAppraisal()
        {
            return View(booklist);
        }
    }
}
