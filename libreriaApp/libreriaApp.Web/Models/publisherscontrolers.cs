using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using libreriaApp.Web.Models;

namespace libreriaApp.Web.Models
{
    public class publisherscontrolers : Controller
    {
        // GET: publisherscontrolers
        public ActionResult Index()
        {
            List<publishersmodel> publisher = new List<publishersmodel>()

            {
                new publishersmodel 
                { Id = 1,
                Name = "Albert Whitman & Company",
                City = "New York",
                State = "Estados Unidos de America",
                Country = "New York"
                },

                new publishersmodel
                { Id = 1,
                Name = "Bancroft Press",
                City = "New York",
                State = "Estados Unidos de America",
                Country = "New York"
                },

                new publishersmodel
                { Id = 1,
                Name = "Regal House Publishing",
                City = "New York",
                State = "Estados Unidos de America",
                Country = "New York"
                },

            };
            return View(publisher);
        }

        // GET: publisherscontrolers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: publisherscontrolers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: publisherscontrolers/Create
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

        // GET: publisherscontrolers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: publisherscontrolers/Edit/5
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

        // GET: publisherscontrolers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: publisherscontrolers/Delete/5
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
