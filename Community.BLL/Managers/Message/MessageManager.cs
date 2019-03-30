using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Community.BLL.Managers.Entity;
using Community.DAL.Message;

namespace Community.BLL.Managers.Message
{
    public class MessageManager:BaseManager<DAL.Message.Message>,IMessageManager
    {
        IMessageRepository _messageRepository;

        public MessageManager(IMessageRepository messageRepository) : base(messageRepository)
        {
            _messageRepository = messageRepository;
            _messageRepository.GetAll();
        }


        public List<DAL.Message.Message> GetAllSorted()
        {
            return _messageRepository.GetBy(x => x.SentTime > DateTime.Today.AddMonths(-1)).OrderByDescending(x => x.SentTime).ToList();
        }
    }
}
