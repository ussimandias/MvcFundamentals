using OdeToFood.Models;

namespace OdeToFood.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OdeToFood.Models.OdeToFoodDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "OdeToFood.Models.OdeToFoodDb";
        }

        protected override void Seed(OdeToFood.Models.OdeToFoodDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Restaurants.AddOrUpdate(
             p => p.Name,

            new Restaurant { Name = "Marrakesh", Address = new Models.Address { City = "Washington", State = "D.C", Country = "USA" } },
            new Restaurant { Name = "Biblos", Address = new Models.Address { City = "Tampa", State = "FL", Country = "USA" } },
            new Restaurant { Name = "N'gam", Address = new Models.Address { City = "NYC", State = "NY", Country = "USA" } },
            new Restaurant { Name = "Cafe Nubian", Address = new Models.Address { City = "Jacksonville", State = "FL", Country = "USA" } }

            );
            context.SaveChanges();
        }
    }
}
