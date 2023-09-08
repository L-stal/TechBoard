using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TechBoard.Models.ViewModels
{
    public class SubjectThreadViewModel
    {
        [Required(ErrorMessage = "Skriv en title!")]
        [DisplayName("Topic")]
        public string ThreadHeading { get; set; }
        public int ThreadId { get; set; }
        public int ThreadRefId { get; set; }
        public int SubjectRefId { get; set; }
        [DisplayName("Post")]
        [Required(ErrorMessage = "Skriv en text!")]
        [DataType(DataType.MultilineText)]
        public string TextBody { get; set; }
        [DisplayName("Heading (optional)")]
        public string PostTitle { get; set; }
    }
}
