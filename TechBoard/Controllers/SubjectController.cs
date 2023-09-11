using Microsoft.AspNetCore.Mvc;
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

            List<SubjectThreadViewModel> threads = dbHelper.LoadThreads(id);

            List<SubjectViewModel> subjects = dbHelper.LoadSubjects();

            var subject = subjects.Where(subject => subject.Id == id).FirstOrDefault();

            ViewBag.SubjectTitle = subject.Title;

            return View(threads);
        }
    }
}
