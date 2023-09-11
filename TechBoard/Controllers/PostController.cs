using Microsoft.AspNetCore.Mvc;
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
            return RedirectToAction("Error","Home");
        }

       
    }
}
