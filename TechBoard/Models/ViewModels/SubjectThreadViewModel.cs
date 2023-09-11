using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace TechBoard.Models.ViewModels
{
    public class SubjectThreadViewModel
    {
        [Required(ErrorMessage = "Skriv en titel!")]
        [DisplayName("Tråd titel")]
        public string ThreadHeading { get; set; }

        [DisplayName("Inläggsrubrik (valfritt)")]
        [AllowNull]
        public string? PostTitle { get; set; }

        public int ThreadId { get; set; }

        public int ThreadRefId { get; set; }

        public int SubjectRefId { get; set; }

        [DisplayName("Innehåll")]
        [Required(ErrorMessage = "Skriv en text!")]
        [DataType(DataType.MultilineText)]
        public string TextBody { get; set; }
    }
}
