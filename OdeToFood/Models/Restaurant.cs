using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
    public class Restaurant : IEnumerable
    {
        
        public virtual int ID { get; set; }
        public virtual string Name { get; set; }
        public virtual Address Address { get; set; }
        //public string ChefsName { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }


        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}