using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechBoard.Models
{
    public class Thread
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Heading { get; set; }

        [ForeignKey("Subject")]
        public int SubjectRefId { get; set; }
        public Subject Subject { get; set; }
    }
}
