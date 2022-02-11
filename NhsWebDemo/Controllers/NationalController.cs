using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NhsWebDemo.Controllers
{
    public class NationalController : Controller
    {
        // GET: NationalController
        public ActionResult Index()
        {
            return View();
        }

        // GET: NationalController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NationalController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NationalController/Create
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

        // GET: NationalController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NationalController/Edit/5
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

        // GET: NationalController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NationalController/Delete/5
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
