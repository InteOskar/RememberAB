using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RememberAB.Models
{
    public class CustomDateRangeAttribute : RangeAttribute
    {
        public CustomDateRangeAttribute() : base(typeof(DateTime), DateTime.Now.AddYears(-120).ToString("yyyy-MM-dd"), DateTime.Now.ToString("yyyy-MM-dd"))
        {

        }
    }
}