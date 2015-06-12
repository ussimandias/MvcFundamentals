namespace OdeToFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address_Street = c.String(),
                        Address_City = c.String(),
                        Address_State = c.String(),
                        Address_Country = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Rating = c.Int(nullable: false),
                        Body = c.String(),
                        Created = c.DateTime(nullable: false),
                        Restaurant_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Restaurants", t => t.Restaurant_ID)
                .Index(t => t.Restaurant_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "Restaurant_ID", "dbo.Restaurants");
            DropIndex("dbo.Reviews", new[] { "Restaurant_ID" });
            DropTable("dbo.Reviews");
            DropTable("dbo.Restaurants");
        }
    }
}
