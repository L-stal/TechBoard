using Microsoft.AspNetCore.Mvc;
using TechBoard.Helper;
using TechBoard.Models;
using TechBoard.Models.ViewModels;

namespace TechBoard.Controllers
{
    public class ThreadController : Controller
    {
        private readonly DataContext _context;

        public ThreadController(DataContext context)
        {
            _context = context;
        }
        // GET: ThreadController
        public ActionResult Index(int id)
        {
            var dbHelper = new DBhelper(_context);

            // Gets post in thread
            List<ThreadPostViewModel> posts = dbHelper.LoadPosts(id);

            return View(posts);
        }

        // GET: ThreadController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ThreadController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ThreadController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ThreadController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ThreadController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ThreadController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ThreadController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
