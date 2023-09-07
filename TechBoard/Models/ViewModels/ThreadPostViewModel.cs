using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechBoard.Models.ViewModels
{
    public class ThreadPostViewModel
    {
        [Required(ErrorMessage = "Du måste ange en titel")]
        public string PostTitle { get; set; }

        [Required(ErrorMessage = "Skriv en text!")]
        public string TextBody { get; set; }
        public int PostId { get; set; }
        
        public int ThreadRefId { get; set; }

    }
}
