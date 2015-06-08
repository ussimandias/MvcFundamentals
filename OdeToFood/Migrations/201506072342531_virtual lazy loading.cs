namespace OdeToFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class virtuallazyloading : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Restaurants", "ChefsName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Restaurants", "ChefsName", c => c.String());
        }
    }
}
