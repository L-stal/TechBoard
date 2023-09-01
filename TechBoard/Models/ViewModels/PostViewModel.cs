using Azure.Identity;

namespace TechBoard.Models.ViewModels
{
    public class PostViewModel
    {
        public string Title { get; set; }
        public string TextBody { get; set; }
        public string UserName { get; set; }
    }
}
