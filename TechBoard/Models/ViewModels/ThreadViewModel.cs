using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TechBoard.Models.ViewModels
{
    public class ThreadViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Heading { get; set; }

        public int SubjectRefId { get; set; }
    }
}
