using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Community.DAL.Base.BaseRepository;
using Community.DAL.Post;

namespace Community.DAL.Base.Repositories
{
    public class PostRepository : BaseRepository<Post.Post>,IPostRepository
    {
        public PostRepository(DbContext context) : base(context)
        {
            
        }
    }
}
