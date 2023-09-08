using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace TechBoard.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [AllowNull]
        public string? Title { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string TextBody { get; set; }



        [ForeignKey("Thread")]
        public int ThreadRefId { get; set; }
        public virtual Thread Thread { get; set; }
    }
}
