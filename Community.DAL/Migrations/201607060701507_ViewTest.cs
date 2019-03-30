using Community.DAL.CustomMigrations;
using Community.DAL.Enums;

namespace Community.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ViewTest : DbMigration
    {
        public override void Up()
        {

            SqlReader reader = new SqlReader();
            
            var scriptCommand = reader.Read(ESqlFileNames.AccNamesPermissions);


            this.CreateView(ESqlFileNames.AccNamesPermissions.ToString(),
                     scriptCommand);
        }
        
        public override void Down()
        {
            Sql("DROP VIEW dbo."+ESqlFileNames.AccNamesPermissions);
        }
    }
}
