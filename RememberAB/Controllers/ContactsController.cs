using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RememberAB.Managers;
using RememberAB.Models;

namespace RememberAB.Controllers
{
    public class ContactsController : Controller
    {
        // GET: Contacts
        //public ActionResult ContactView()
        //{
        //    return View();
        //}

        [HttpPost]
        public ActionResult Create(ContactsModel contact)
        {
            return View();
        }

        public ActionResult AddContact()
        {
            return View();
        }

        public ActionResult CreateContact(ContactsModel contact)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("AddContact");
            }
            var contactsManager = new ContactsManager();
                contactsManager.ContactsAdd(contact);
                return RedirectToAction("ContactView");
        }
        [HttpGet]
        public ActionResult ContactView()
        {
            var contactsManager = new ContactsManager();
            var getAll = contactsManager.GetContacts();
            return View(getAll);
        }
        //[ActionName("contact-delete")]
        public ActionResult ContactDelete(int id)
        {
            var contactManager = new ContactsManager();
            contactManager.ContactsDelete(id);
            return RedirectToAction("ContactView");
        }
    }
}