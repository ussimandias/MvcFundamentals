namespace OdeToFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReviewTable : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Reviews", new[] { "Restaurant_ID" });
            DropTable("dbo.Reviews");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Rating = c.Int(nullable: false),
                        Body = c.String(),
                        Created = c.DateTime(nullable: false),
                        Restaurant_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateIndex("dbo.Reviews", "Restaurant_ID");
        }
    }
}
