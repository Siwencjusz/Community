using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Community.DAL.Base.Entity;

namespace Community.DAL.Comment
{
    [Table("Comments")]
    public class Comment:Entity
    {

        public virtual User.User User { get; set; }

        public virtual Post.Post Post { get; set; }

        public virtual List<Document.Document> Documents { get; set; }

        [Required]
        [MaxLength(255)]
        public string Content { get; set; }

        [Required]
        public DateTime PublishDate { get; set; }

        
    }
}
