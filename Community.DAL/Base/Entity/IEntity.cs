using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Community.DAL.Base.Entity
{
    public interface IEntity
    {
        int Id { get; set; }
    }
}
