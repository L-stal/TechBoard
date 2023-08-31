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
        {

            title = char.ToUpper(title[0]) + title.Substring(1);

            Subject subject = new Subject { Id = 1, Title = title };
            return View(subject);
        }*/
    }
}
