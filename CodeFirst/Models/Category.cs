using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }
}