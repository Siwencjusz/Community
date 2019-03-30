using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Community.DAL.Base.Entity;

namespace Community.DAL.Post
{
    [Table("Posts")]
    public class Post:Entity
    {

        public virtual User.User User { get; set; }

        public virtual List<Comment.Comment> Comments { get; set; }

        public virtual List<Document.Document> Documents { get; set; }      

        [Required]
        [MaxLength(1000)]
        public string Content { get; set; }

        [Required]
        public DateTime PublishDate { get; set; }


    }
}
