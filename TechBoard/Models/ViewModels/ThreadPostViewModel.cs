using System.ComponentModel.DataAnnotations.Schema;

namespace TechBoard.Models.ViewModels
{
    public class ThreadPostViewModel
    {
        public string ThreadHeading { get; set; }
        public string PostTitle { get; set; }
        public string TextBody { get; set; }
        public int PostId { get; set; }
        [ForeignKey("Thread")]
        public int ThreadRefId { get; set; }
    }
}
