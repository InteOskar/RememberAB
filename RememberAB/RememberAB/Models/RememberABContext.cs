using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using RememberAB.Models;
using System.Web;

namespace RememberAB.Models
{
    public class RememberABContext : DbContext
    {
        public RememberABContext() : base ("name=RememberAB")
        {
            Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<ContactsModel> ContactsModels { get; set; }
    }
}