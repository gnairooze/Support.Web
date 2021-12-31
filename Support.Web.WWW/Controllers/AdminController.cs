using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Support.Web.WWW.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            var modelviews = CreateSample();
            return View(modelviews);
        }

        private List<Models.AdminViewModel> CreateSample()
        {
            var models = new List<Models.AdminViewModel>() { 
                new Models.AdminViewModel(){ Description = "description 1", Id = 1, Module = "Login", Name = "dbo.ActivateUser", RetrunsData = false},
                new Models.AdminViewModel(){ Description = "description 2", Id = 1, Module = "Login", Name = "dbo.ReadUsers", RetrunsData = true}
            };

            return models;
        }
    }
}
