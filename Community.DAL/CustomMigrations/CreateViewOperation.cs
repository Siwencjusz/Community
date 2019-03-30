using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community.DAL.CustomMigrations
{
    public class CreateViewOperation:MigrationOperation
    {
        public CreateViewOperation(string viewName, string viewQueryString)
            : base(null)
        {
            ViewName = viewName;
            ViewQueryString = viewQueryString;
        }

        public string ViewName { get; set; }
        public string ViewQueryString { get; set; }

        public override bool IsDestructiveChange
        {
            get { return false; }
        }
    }
}
