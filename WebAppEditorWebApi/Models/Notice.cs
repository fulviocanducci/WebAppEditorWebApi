using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebAppEditorWebApi.Models
{
    [Table("notices")]
    public class Notice
    {
        [Key()]
        public int Id { get; set; }

        [Required()]
        [Column("title")]
        public string Title { get; set; }

        [Required()]
        [Column("subtitle")]
        public string SubTitle { get; set; }

        [Required()]
        [Column("texto")]
        public string Text { get; set; }

        [Required()]
        [Column("createdat")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
