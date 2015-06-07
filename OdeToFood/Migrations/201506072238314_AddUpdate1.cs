namespace OdeToFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUpdate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReviewDBs",
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
            DropForeignKey("dbo.ReviewDBs", "Restaurant_ID", "dbo.Restaurants");
            DropIndex("dbo.ReviewDBs", new[] { "Restaurant_ID" });
            DropTable("dbo.ReviewDBs");
        }
    }
}
