using Microsoft.AspNetCore.Mvc;
using System.Web.Razor.Tokenizer;
using TechBoard.Helper;
using TechBoard.Models;
using TechBoard.Models.ViewModels;

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

            // Subject
            Subject subject = dbHelper.LoadSubject(id);

            if (subject == null)
            {
                return new NotFoundResult();
            }

            // Threads
            List<Models.Thread> threads = dbHelper.LoadThreads(id);
            List<ThreadViewModel> threadsViewModel = new List<ThreadViewModel>();

            foreach(var thread in threads)
            {
                var threadView = new ThreadViewModel
                {
                    Id = thread.Id,
                    Heading = thread.Heading,
                };
                threadsViewModel.Add(threadView);
            }

            if (subject == null)
            {
                return new NotFoundResult();
            }

            // Combine
            var combined = new SubjectThreadViewModel
            {
                Threads = threadsViewModel,
                Subject = subject,
            };

            Console.WriteLine("Index id: " + id);
            
            return View(combined);
        }
    }
}
