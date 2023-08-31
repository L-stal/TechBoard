using Microsoft.AspNetCore.Mvc;
using TechBoard.Helper;
using TechBoard.Models;

namespace TechBoard.Controllers
{
    public class SubjectController : Controller
    {
        private readonly DataContext _context;
        public SubjectController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index(int id)
        {
            var dbHelper = new DBhelper(_context);
            List<Models.Thread> threads = dbHelper.LoadThreads(id);
            if (threads != null)
            {
                return new NotFoundResult();
            }
            return View(threads);
        }

        /*public IActionResult Index(string title)
        public List<ThreadViewModel> GetThreads()
        {
            var thread0 = new ThreadViewModel { Id = 0, Heading = "Bästa GPU?", SubjectRefId = 0 };
            var thread1 = new ThreadViewModel { Id = 1, Heading = "Photoshop version", SubjectRefId = 1 };
            var thread2 = new ThreadViewModel { Id = 2, Heading = "Senaste uppdateringen av VSCode", SubjectRefId = 1 };
            var threads = new List<ThreadViewModel> { thread0, thread1, thread2 };

            return threads;
        }

        public IActionResult Index(string title)

        {
            // Threads
            var threads = GetThreads();

            // Subject
            title = char.ToUpper(title[0]) + title.Substring(1);
            Subject subject = new Subject { Id = 1, Title = title };

            Subject subject = new Subject { Id = 1, Title = title };
            return View(subject);
        }
            // Combine
            var combined = new SubjectThreadViewModel
            {
               Threads = threads,
               Subject = subject
            };
            
            return View(combined);
        }*/

    }
}
