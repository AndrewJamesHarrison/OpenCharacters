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

        List<Character> charList = new List<Character>();

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }

        public ActionResult Character()
        {
            ViewBag.Title = "Home Page";
            charList.Add(new Character("Test Name", charList.Count()));
            return View(charList.Last());
        }

        public ActionResult Update(Character c)
        {
            charList.RemoveAt(c.TempID);
            charList.Insert(c.TempID, c);

            return RedirectToAction("Index");
        }

    }
}
