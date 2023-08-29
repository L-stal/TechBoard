using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechBoard.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string TextBody { get; set; }
        [Required]
        public string UserName { get; set; }

        [ForeignKey("Thread")]
        public int ThreadtRefId { get; set; }
        public Thread Thread { get; set; }
    }
}
