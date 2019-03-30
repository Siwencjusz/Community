using Community.DAL.CustomMigrations;

namespace Community.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class View : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "AccName", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "AccName");
        }
    }
}
