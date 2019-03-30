using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Community.DAL.Base.BaseRepository;
using Community.DAL.Comment;

namespace Community.DAL.Base.Repositories
{
    public class CommentRepository:BaseRepository<Comment.Comment>,ICommentRepository
    {
        public CommentRepository(DbContext context) : base(context)
        {
            
        }
    }
}
