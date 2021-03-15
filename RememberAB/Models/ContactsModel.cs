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
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Dateformat: yyyy-mm-dd")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
        ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [CustomDateRange]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Enter a valid email with @")]
        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Confirm email")]
        [Compare("Email", ErrorMessage = "The email addresses do not match.")]
        public string ConfirmEmail { get; set; }

        //[Required]
        //[StringLength(20, MinimumLength = 8)]
        //public string Password { get; set; }

        //[Required]
        //[StringLength(20, MinimumLength = 1)]
        //public string UserName { get; set; }
    }
}