using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Community.DAL.Base.Entity;

namespace Community.DAL.User
{
    [Table("Users")]
    public class User:Entity
    {


        public virtual List<Comment.Comment> Comments { get; set; }

        public virtual List<Post.Post> Posts { get; set; }

        public virtual List<Permission.Permission> Permissions { get; set; }

        [Required]
        [MaxLength(20)]
        public string AccName { get; set; }

        [Required]
        [MaxLength(255)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(255)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(255)]
        public string Email { get; set; }

        [Required]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        
    }
}
