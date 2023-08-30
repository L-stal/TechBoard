using Microsoft.AspNetCore.Mvc;
using TechBoard.Models;

namespace TechBoard.Controllers
{
    public class SubjectController : Controller
    {
        public IActionResult Index(string title)
        {

            title = char.ToUpper(title[0]) + title.Substring(1);

            Subject subject = new Subject { Id = 1, Title = title };            
            return View(subject);
        }
    }
}
