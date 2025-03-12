using Microsoft.AspNetCore.Mvc;

namespace GitBranchesDemo.Controllers
{
    public class KeyurController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
