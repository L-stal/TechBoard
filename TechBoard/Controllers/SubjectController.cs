using Microsoft.AspNetCore.Mvc;

namespace TechBoard.Controllers
{
    public class SubjectController : Controller
    {
        public IActionResult Index()
        {
            Console.WriteLine("Subject!");
            return View();
        }
    }
}
