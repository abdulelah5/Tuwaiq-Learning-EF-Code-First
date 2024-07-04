using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class Users
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Please Enter valid username")]
        [Display(Name = "Username")]
        public string username { get; set; }
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please Enter valid password")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}