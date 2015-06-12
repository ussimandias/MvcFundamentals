namespace OdeToFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DiningDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "DiningDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Reviews", "DininingDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "DininingDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Reviews", "DiningDate");
        }
    }
}
