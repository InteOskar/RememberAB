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
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Username required")]
        [StringLength(20, MinimumLength = 1)]
        public string UserName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
        ApplyFormatInEditMode = true)]
        [Range(0, 200)]
        public DateTime BirthDate { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 8)]
        public string Password { get; set; }
    }
}