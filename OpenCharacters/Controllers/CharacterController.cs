using OpenCharacters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OpenCharacters.Controllers
{
    public class CharacterController : Controller
    {
        // GET: Character
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            ViewBag.Title = "Home Page";
            return View(new Character("Test Name"));
        }

        [HttpPost]
        public ActionResult Update(Character c)
        {
            return View(c);
        }
    }
}