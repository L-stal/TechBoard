using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace TechBoard.Models.ViewModels
{
    public class ThreadPostViewModel
    {
        [AllowNull]
        public string? ThreadHeading { get; set; }

        [DisplayName("Inläggsrubrik (valfritt)")]
        [AllowNull]
        public string? PostTitle { get; set; }

        [Required(ErrorMessage = "Skriv en text!")]
        [DisplayName("Innehåll")]
        public string TextBody { get; set; }
        public int PostId { get; set; }
        public int ThreadRefId { get; set; }

    }
}
