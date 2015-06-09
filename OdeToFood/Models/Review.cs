using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;

namespace OdeToFood.Models
{
    public class Review : IValidatableObject
    {      
        public int ID { get; set; }
        public Restaurant Restaurant { get; set; }
        public string Name { get; set; }
        [Range(1,10)]
        public int Rating { get; set; }       
        [Required]
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }

        public DateTime DiningDate { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var field = new[] { "DiningDate" };

            if (DiningDate > DateTime.Now)
            {
                yield return new ValidationResult("Dinning Date can not be in the future", field);
            }
            if (DiningDate < DateTime.Now.AddYears(-1))
            {
                yield return new ValidationResult("Dinning Date can not be too far in the past", field);
            }
            //throw new NotImplementedException();
        }
    }
}