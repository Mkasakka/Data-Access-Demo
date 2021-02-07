using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccessDemo.Models;
using DataLibrary;
using static DataLibrary.BusinessLogic.EmployeeProcessor;

namespace DataAccessDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult SignUp()
        {
            ViewBag.Message = "Employee signUp";
            var model = new EmployeeModel();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(EmployeeModel model)
        {

            if (ModelState.IsValid)
            {
                int rect = CreateEmployee(model.EmployeeId, 
                    model.FirstName, 
                    model.LastName, 
                    model.EmailAddress);

                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Employees()
        {
            ViewBag.Message = "Employee listing";
            
            var dbModel = LoadEmployeeDataModels();
            var viewModel = new List<EmployeeViewModel>();
            foreach (var row in dbModel)
            {
                viewModel.Add(new EmployeeViewModel
                {
                    FirstName = row.FirstName,
                    LastName = row.LastName,
                    EmailAddress = row.EmailAddress,
                    EmployeeId = row.EmployeeId
                });
                
            }

            return View(viewModel);
        }

    }
}