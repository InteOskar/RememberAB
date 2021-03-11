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
        public ActionResult ContactView()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddContact()
        {
            return View();
        }

        public ActionResult DeleteContact()
        {
            return View();
        }
    }
}