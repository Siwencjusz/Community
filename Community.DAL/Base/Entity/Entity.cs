using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community.DAL.Base.Entity
{


    public abstract class Entity : IEntity
    {
        public int Id { get; set; }
    }
}
