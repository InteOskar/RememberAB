using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RememberAB.Controllers
{
    public class ContactsController : Controller
    {
        // GET: Contacts
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "https://www.youtube.com/watch?v=Gs069dndIYk";

            return View();
        }

        public ActionResult GetInTouch()
        {
            return View();
        }
    }
}