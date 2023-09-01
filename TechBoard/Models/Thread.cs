using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechBoard.Models
{
    public class Thread
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Heading { get; set; }

        [ForeignKey("Subject")]
        public int SubjectRefId { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
