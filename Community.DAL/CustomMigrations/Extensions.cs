using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community.DAL.CustomMigrations
{
    public static class Extensions
    {
        public static void CreateView(this DbMigration migration, string viewName, string viewQueryString)
        {
            ((IDbMigration) migration)
                .AddOperation(new CreateViewOperation(viewName,viewQueryString));
        }

    }
}
