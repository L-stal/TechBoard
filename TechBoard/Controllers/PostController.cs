using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;
using TechBoard.Helper;
using TechBoard.Models;
using TechBoard.Models.ViewModels;

namespace TechBoard.Controllers
{
    public class PostController : Controller
    {
        private readonly DataContext _context;

        public PostController(DataContext context)
        {
            _context = context;
        }
        // GET: PostController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PostController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PostController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PostController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ThreadPostViewModel post)
        {
            var dbHelper = new DBhelper(_context);

            if (ModelState.IsValid) 
            {
                var newPost = new Post
                {
                    TextBody = post.TextBody,
                    Title = post.PostTitle,
                    UserName = post.UserName,
                    ThreadRefId = post.ThreadRefId,
                };
                try
                {

                   dbHelper.AddPost(newPost);

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    throw; 
                }
                return RedirectToAction("Index", "Thread", new { id = post.ThreadRefId });
            }
            var errors = ModelState
    .Where(x => x.Value.Errors.Count > 0)
    .Select(x => new { x.Key, x.Value.Errors })
    .ToArray();

            Debug.WriteLine(errors + "!!!!!!!!!!!!!!!!!!");
            return RedirectToAction("Index");
        }

        // GET: PostController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PostController/Edit/5
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

        // GET: PostController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PostController/Delete/5
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
