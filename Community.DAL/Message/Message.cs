using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Community.DAL.Base.Entity;

namespace Community.DAL.Message
{
    [Table("Messages")]
    public class Message:Entity
    {

        public virtual User.User Sender { get; set; }

        public virtual List<Document.Document> Documents { get; set; }

        public virtual User.User Receiver { get; set; }

        [Required]
        [MaxLength(255)]
        public string Text { get; set; }

        [Required]
        public DateTime SentTime { get; set; }
    }
}
