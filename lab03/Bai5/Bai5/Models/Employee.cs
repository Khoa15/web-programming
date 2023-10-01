using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bai5.Models
{
    public class Employee
    {
        [Required()]
        public string Name { get; set; }
        [Required()]
        public string Address { get; set; }
        [Required()]
        public float Salary { get; set; }
        [Required()]
        [EmailAddress(ErrorMessage ="Please enter correct address")]
        public float Email { get; set; }

    }
}