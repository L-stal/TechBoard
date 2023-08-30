using Microsoft.AspNetCore.Mvc;
using TechBoard.Models.ViewModels;

namespace TechBoard.Controllers
{
    public class ThreadController : Controller
    {
        public IActionResult Index()
        {
            var thread0 = new ThreadViewModel { Id = 0, Heading = "Bästa GPU?", SubjectRefId = 0 };
            var thread1 = new ThreadViewModel { Id = 1, Heading = "Photoshop version", SubjectRefId = 1 };
            var thread2 = new ThreadViewModel { Id = 2, Heading = "Senaste uppdateringen av VSCode", SubjectRefId = 1 };

            var threads = new List<ThreadViewModel> { thread0, thread1, thread2 };
            
            return View(threads);
        }
    }
}
