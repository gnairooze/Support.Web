using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Support.Web.WWW.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Support.Web.WWW.Controllers
{
    public class UserController : Controller
    {
        private static List<Models.ItemViewModel> _ViewModels;
        public UserController()
        {
            _ViewModels = CreateSample();
        }

        public IActionResult Index()
        {
            return View(_ViewModels);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            var viewModel = _ViewModels.Find(v => v.Id == id);
            return View(viewModel);
        }

        // GET: User/Run/5
        public ActionResult Run(int id)
        {
            var viewModel = _ViewModels.Find(v => v.Id == id);
            return View(viewModel);
        }

        // POST: User/Run/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Run(int id, IFormCollection collection)
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
        private static List<ItemViewModel> CreateSample()
        {
            var models = new List<Models.ItemViewModel>() {
                new Models.ItemViewModel(){ Description = "description 1", Id = 1, Module = "Login", Name = "dbo.ActivateUser", RetrunsData = false},
                new Models.ItemViewModel(){ Description = "description 2", Id = 2, Module = "Login", Name = "dbo.ReadUsers", RetrunsData = true}
            };

            models[0].Parameters.AddRange(new List<Models.ParameterViewModel>() { 
                new ParameterViewModel(){ DataType = "nvarchar", IsOutput = false, MaxLength = 20, Name = "Username", Nullable = false, Order = 1},
                new ParameterViewModel(){ DataType = "int", IsOutput = true, Name = "Result", Nullable = false, Order = 2}
            });

            models[1].ResultData = GenerateDataSet();
            return models;
        }

        private static DataSet GenerateDataSet()
        {
            var dset = new DataSet();

            dset.Tables.Add(new DataTable());
            dset.Tables[0].Columns.AddRange(new DataColumn[] {
                new DataColumn("ID"),
                new DataColumn("Name"),
                new DataColumn("CreateDate")
            });

            dset.Tables.Add(new DataTable());
            dset.Tables[1].Columns.AddRange(new DataColumn[] {
                new DataColumn("CorrelationID"),
                new DataColumn("Module"),
                new DataColumn("CreateDate")
            });

            dset.Tables[0].Rows.Add(new string[] { "1", "John", "2022-01-01" });
            dset.Tables[0].Rows.Add(new string[] { "2", "Smith", "2022-01-02" });

            dset.Tables[1].Rows.Add(new string[] { "01", "Login", "2022-01-03" });
            dset.Tables[1].Rows.Add(new string[] { "02", "Log", "2022-01-04" });

            return dset;
        }
    }
}
