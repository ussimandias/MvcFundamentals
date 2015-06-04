using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
    public class Restaurant
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public string ChefsName { get; set; }

        //public List<Review> Reviews { get; set; } 
        
    }
}