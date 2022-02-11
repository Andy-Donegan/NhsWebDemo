using Microsoft.AspNetCore.Mvc;



namespace NhsWebDemo.Controllers
{
    public class NHSController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
               
    }
}
