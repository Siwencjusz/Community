using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Community.DAL.CustomMigrations;

namespace Community.DAL
{
    class CustomDbConfiguration:DbConfiguration
    {
        public CustomDbConfiguration()
        {
            SetMigrationSqlGenerator("System.Data.SqlClient", () => new CustomMigrationGenerator());
        }
    }
}
