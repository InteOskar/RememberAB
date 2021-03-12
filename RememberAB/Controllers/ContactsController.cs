﻿using System;
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
        public ActionResult ContactView()
        {
            return View();
        }

        //[HttpPost]
        public ActionResult AddContact(ContactsModel contact)
        {
            return View();
        }

        public ActionResult DeleteContact()
        {
            return View();
        }

        public ActionResult Fusk(ContactsModel contact)
        {
            return View();
        }

        public ActionResult CreateContact(ContactsModel contact)
        {
            var contactsManager = new ContactsManager();
            contactsManager.ContactsAdd(contact);
            return View("ContactView");
        }
    }
}