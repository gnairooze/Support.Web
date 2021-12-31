using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Support.Web.WWW.Controllers
{
    public class AdminController : Controller
    {
        private static List<Models.AdminViewModel> _ViewModels;

        public AdminController()
        {
            _ViewModels = CreateSample();
        }
        // GET: AdminController
        public ActionResult Index()
        {
            return View(_ViewModels);
        }

        // GET: AdminController/Details/5
        public ActionResult Details(int id)
        {
            var viewModel = _ViewModels.Find(v => v.Id == id);
            return View(viewModel);
        }

        // GET: AdminController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminController/Create
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

        // GET: AdminController/Edit/5
        public ActionResult Edit(int id)
        {
            var viewModel = _ViewModels.Find(v => v.Id == id);
            return View(viewModel);
        }

        // POST: AdminController/Edit/5
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

        // GET: AdminController/Delete/5
        public ActionResult Delete(int id)
        {
            var viewModel = _ViewModels.Find(v => v.Id == id);
            return View(viewModel);
        }

        // POST: AdminController/Delete/5
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

        private static List<Models.AdminViewModel> CreateSample()
        {
            var models = new List<Models.AdminViewModel>() {
                new Models.AdminViewModel(){ Description = "description 1", Id = 1, Module = "Login", Name = "dbo.ActivateUser", RetrunsData = false},
                new Models.AdminViewModel(){ Description = "description 2", Id = 2, Module = "Login", Name = "dbo.ReadUsers", RetrunsData = true}
            };

            return models;
        }
    }
}
