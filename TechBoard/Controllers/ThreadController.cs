using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechBoard.Helper;
using TechBoard.Models.ViewModels;
using TechBoard.Models;

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
            List<Post> posts = dbHelper.LoadPosts(id);
            List<PostViewModel> postViewModel = new List<PostViewModel>();

            foreach (var post in posts)
            {
                var postView = new PostViewModel
                {
                    UserName = post.UserName,
                    TextBody = post.TextBody,
                    Title = post.Title,
                    ThreadRefId = post.ThreadRefId,

                };
                postViewModel.Add(postView);


            }
            return View(postViewModel);
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
    */
}
