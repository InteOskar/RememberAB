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
        public ActionResult AddContact()
        {
            return View();
        }

        [HttpPost]
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

        [HttpPost]
        public ActionResult ContactView(string firstName)
        {
            var contactsManager = new ContactsManager();
            var getAll = contactsManager.GetContacts();

            if (firstName == "")
            {
                contactsManager.GetContacts();
                return View(getAll);    
            }
            else
            {
                var getContact = contactsManager.GetContacts().Where(x => x.FirstName.ToLower() == firstName.ToLower()).ToList();
                
                if (getContact.Count >= 1)
                {
                return View(getContact);
                }
                else 
                {
                    getContact = contactsManager.GetContacts().Where(x => x.Surname.ToLower() == firstName.ToLower()).ToList();
                    if (getContact.Count >= 1)
                    {
                        return View(getContact);
                    }
                    else
                    {
                        getContact = contactsManager.GetContacts().Where(x => x.Email.ToLower() == firstName.ToLower()).ToList();
                        return View(getContact);
                    }
                }
            }
        }

        public ActionResult ContactDelete(int id)
        {
            var contactManager = new ContactsManager();
            contactManager.ContactsDelete(id);
            return RedirectToAction("ContactView");
        }

        public ActionResult ContactSearch()
        {
            return View();
        }
    }
}