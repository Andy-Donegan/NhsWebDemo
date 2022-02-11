using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NhsWebDemo.Controllers
{
    public class RegionController : Controller
    {
        // GET: RegionController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RegionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RegionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegionController/Create
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

        // GET: RegionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RegionController/Edit/5
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

        // GET: RegionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RegionController/Delete/5
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
