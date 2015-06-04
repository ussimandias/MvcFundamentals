using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web;

namespace OdeToFood.Models
{
    public class FoodDb
    {
        static FoodDb()
        {

         var  _newReview = new List<RestaurantReview>();
           _newReview.Add(new RestaurantReview
            {                              
                    Created = DateTime.Now, 
                    Body = "Great FrenchFood", 
                    ID = 1, 
                    Name = "Mr Smith", 
                    Rating = 9, 
                    Restaurant = new Restaurant
                    {
                        Name = "Mannequin Pis"
                    }
                });

           _newReview.Add(new RestaurantReview
            {            
                    Created = DateTime.Now, 
                    Body = "Fantastic Steak", 
                    ID = 1, 
                    Name = "Mr Brown", 
                    Rating = 9, 
                    Restaurant = new Restaurant
                    {
                        Name = "Mandarins"
                    }
                });


           _newReview.Add(new RestaurantReview
            {                                
                    Created = DateTime.Now, 
                    Body = "Fantastic Steak", 
                    ID = 1, 
                    Name = "Mr Brown", 
                    Rating = 9, 
                    Restaurant = new Restaurant
                    {
                        Name = "Mandarins"
                    }
                });
            }

        public object Reviews { get; set; }
        public List<RestaurantReview> _newReview { get; set; }
    }
}