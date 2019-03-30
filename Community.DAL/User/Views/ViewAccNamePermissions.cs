using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community.DAL.User.Views
{
    [Table("dbo.ViewAccNamePermissions")]
    public class ViewAccNamePermissions
    {
        [Key]
        public Nullable<int> Id { get; set; }
        public string AccName { get; set; }
        public string PermissionName { get; set; }
    }
}
