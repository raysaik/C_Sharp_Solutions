using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityFramework_MVCWeb_DataAccessLayer;
using EntityFramework_MVCWeb_BusinessAccessLayer.Contracts;
using EntityFramework_MVCWeb.Models;
using EntityFramework_MVCWeb_BusinessAccessLayer.Domain_Models;

namespace EntityFramework_MVCWeb.Controllers
{
    public class HomeController : Controller  //All controllers inherit from System.Web.MVC.Controller (abstract class)
    {
        //
        // GET: /Home/
        private IBusinessAccessLayer bl = null;
        internal HomeScreenViewModel hsVM;
        public HomeController()
        {
            //ISSUE: dependency injected. NEED IOC pattern
            bl = new EntityFramework_MVCWeb_BusinessAccessLayer.BAL();
            hsVM = new HomeScreenViewModel(new Doctors()); 
        }
        public ActionResult Index()
        {
            //Doctor doc = new Doctor();
            //IEnumerable<Doctor_BAL> doc = bl.GetAllDoctors();
            hsVM.doctors.DoctorsBAL = bl.GetAllDoctors();
            ViewBag.Title = "Home";
            return View(hsVM);
        }

        public ActionResult SearchDoctorsByField(string SearchTerm)
        {
            return null;
        }

    }
}
