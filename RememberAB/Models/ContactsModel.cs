using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RememberAB.Models
{
    public class ContactsModel
    {
        [Key]
        private int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}