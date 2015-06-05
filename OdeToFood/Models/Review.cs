using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;

namespace OdeToFood.Models
{
    public class Review
    {
        
        public int ID { get; set; }
        public Restaurant Restaurant { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }
        public DateTime Created { get; set; }
    }
}