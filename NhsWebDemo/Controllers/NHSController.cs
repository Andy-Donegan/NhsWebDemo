using Microsoft.AspNetCore.Mvc;

namespace NhsWebDemo.Controllers
{
    public class NHSController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Local()
        {
            return View();
        }
        public IActionResult Regional()
        {
            return View();
        }
        public IActionResult National()
        {
            return View();
        }
    }
}
