using FizzBuzzApplication.BusinessFacade.Interface;
using FizzBuzzApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FizzBuzzApplication.Controllers
{
    public class FizzBuzzController : Controller
    {
        private readonly IDivisibleFacade divisible;

        public FizzBuzzController(IDivisibleFacade divisible)
        {
            this.divisible = divisible;
        }
        // GET: FizzBuzz
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DisplayForm(int input)
        {
            var results = divisible.Division(input);
            return View("DisplayForm", results);
        }
    }
}