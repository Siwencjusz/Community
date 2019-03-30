using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Community.DAL.Base.Entity;

namespace Community.DAL.Document
{
    [Table("Documents")]
    public class Document:Entity
    {
        
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        public byte [] Content { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Format { get; set; }
    }
}
