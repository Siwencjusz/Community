using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Community.DAL.Base.BaseRepository;
using Community.DAL.User;

namespace Community.DAL.Base.Repositories
{
    public class UserRepository :BaseRepository<User.User>,IUserRepository
    {
        public UserRepository(DbContext context):base(context)
        {
            
        }
        
    }
}
