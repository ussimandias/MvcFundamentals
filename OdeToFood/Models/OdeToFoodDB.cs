﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
    public class    OdeToFoodDb : DbContext
    {

        public DbSet<Restaurant>  Restaurants { get; set; }
        //public DbSet<Review> Reviews{ get; set; }
        public System.Data.Entity.DbSet<OdeToFood.Models.ReviewDB> ReviewDBs { get; set; } 
    }
}