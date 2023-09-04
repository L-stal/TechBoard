using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TechBoard.Controllers
{
    public class PostControllercs : Controller
    {
        // GET: PostControllercs
        public ActionResult Index()
        {
            return View();
        }

        // GET: PostControllercs/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PostControllercs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PostControllercs/Create
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

        // GET: PostControllercs/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PostControllercs/Edit/5
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

        // GET: PostControllercs/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PostControllercs/Delete/5
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
