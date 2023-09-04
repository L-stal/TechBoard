using Microsoft.AspNetCore.Mvc;
using TechBoard.Helper;
using TechBoard.Models;

namespace TechBoard.ViewComponents
{
    public class NavBar : ViewComponent
    {
        private readonly DataContext _context;

        public NavBar(DataContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var dbHelper = new DBhelper(_context);
            List<Subject> subjects = dbHelper.LoadSubjects();

            return View(subjects);
        }
    }
}
