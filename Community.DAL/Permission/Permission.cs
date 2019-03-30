using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Community.DAL.Base.Entity;

namespace Community.DAL.Permission
{
    public class Permission:Entity
    {

        [Required]
        public string PermissionName { get; set; }

        public virtual List<User.User> Users { get; set; }
    }
}
