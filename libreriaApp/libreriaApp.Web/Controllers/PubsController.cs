using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace libreriaApp.Web.Controllers
{
    public class PubsController : Controller
    {
        // GET: PubsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PubsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PubsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PubsController/Create
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

        // GET: PubsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PubsController/Edit/5
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

        // GET: PubsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PubsController/Delete/5
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
