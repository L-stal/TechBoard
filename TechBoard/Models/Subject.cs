using System.ComponentModel.DataAnnotations;

namespace TechBoard.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public virtual ICollection<Thread> Threads { get; set; }
    }
}
