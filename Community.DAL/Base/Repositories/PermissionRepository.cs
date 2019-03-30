using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Community.DAL.Base.BaseRepository;
using Community.DAL.Permission;

namespace Community.DAL.Base.Repositories
{
    public class PermissionBaseBaseRepository:BaseRepository<Permission.Permission>,IPermissionBaseRepository
    {
        public PermissionBaseBaseRepository(DbContext context) : base(context)
        {
            
        }
    }
}
