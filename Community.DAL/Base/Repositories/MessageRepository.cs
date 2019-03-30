using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Community.DAL.Base.BaseRepository;
using Community.DAL.Message;

namespace Community.DAL.Base.Repositories
{
    public class MessageRepository : BaseRepository<Message.Message>,IMessageRepository
    {
        public MessageRepository(DbContext context) : base(context)
        {
            
        }
    }
}
