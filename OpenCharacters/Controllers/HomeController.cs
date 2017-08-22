using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OpenCharacters.Models;

namespace OpenCharacters.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Create()
        {
            ViewBag.Title = "Home Page";
            Character userCharacter = new Character("Test Name");

            return View();
        }

    }
}
