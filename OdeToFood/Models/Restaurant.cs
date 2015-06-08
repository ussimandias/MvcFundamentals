using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
    public class Restaurant
    {
        
        public virtual int ID { get; set; }
        public virtual string Name { get; set; }
        public virtual Address Address { get; set; }
        //public string ChefsName { get; set; }
        public virtual ICollection<ReviewDB> Reviews { get; set; }
         
        
    }
}