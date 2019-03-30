using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Community.BLL.Managers.Entity;

namespace Community.BLL.Managers.Message
{
    interface IMessageManager:IBaseManager<DAL.Message.Message>
    {
        List<DAL.Message.Message> GetAllSorted();
    }
}
