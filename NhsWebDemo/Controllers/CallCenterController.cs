using Microsoft.AspNetCore.Mvc;

namespace NhsWebDemo.Controllers
{
    public class CallCenterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
