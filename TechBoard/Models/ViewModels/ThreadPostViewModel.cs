using System.ComponentModel.DataAnnotations.Schema;

namespace TechBoard.Models.ViewModels
{
    public class ThreadPostViewModel
    {
        public string PostTitle { get; set; }
        public string TextBody { get; set; }
        public int PostId { get; set; }
        public string UserName { get; set; }    

    }
}
