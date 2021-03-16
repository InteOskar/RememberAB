using RememberAB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RememberAB.Managers
{
    public class ContactsManager
    {   
        public void ContactsAdd(ContactsModel contact)
        {
            using (var db = new RememberABContext())
            {
                db.ContactsModels.Add(contact);
                db.SaveChanges();
            }
        }
        
        public void ContactsDelete(int id)
        {
            using (var db = new RememberABContext())
            {
                var contact = db.ContactsModels.Find(id);
                db.ContactsModels.Remove(contact);
                db.SaveChanges();
            }
        }

        public List<ContactsModel> GetContacts()
        {
            using (var db = new RememberABContext())
            {
                return db.ContactsModels.ToList();
            }
        }

        public void ContactsSearch(string firstName)
        {
            using (var db = new RememberABContext())
            {
                var contact = db.ContactsModels.Where(c => c.FirstName.Contains(firstName) || firstName == null).ToList();
            }
        }
    }
}