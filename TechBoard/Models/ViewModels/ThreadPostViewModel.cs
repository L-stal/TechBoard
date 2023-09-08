using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace TechBoard.Models.ViewModels
{
    public class ThreadPostViewModel
    {
        [DisplayName("Heading (optional)")]
        [AllowNull]
        public string? PostTitle { get; set; }

        [Required(ErrorMessage = "Skriv en text!")]
        [DisplayName("Post")]
        public string TextBody { get; set; }
        public int PostId { get; set; }
        public int ThreadRefId { get; set; }

    }
}
