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

            // Subject
            /*Subject subject = dbHelper.LoadSubject(id);

            if (subject == null)
            {
                return new NotFoundResult();
            }*/

            List<SubjectThreadViewModel> threads = new List<SubjectThreadViewModel>();

            threads = dbHelper.LoadThreads(id);

            return View(threads);
        }
    }
}
