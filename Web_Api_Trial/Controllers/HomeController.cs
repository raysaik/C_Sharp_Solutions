using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Web_Api_Trial.Controllers
{
    using Data_Access_Layer_LinqToSql;
    using Web_Api_Trial.Models;

    public class HomeController : Controller
    {
        private ProductViewModel pvm;
        public HomeController()
        {
           pvm  = new ProductViewModel();
        }
        public ActionResult Index()
        {
            
            using (AdventureWorks2012DataContext dataContext = new AdventureWorks2012DataContext())
            {
                IEnumerable<Product> products = (from data in dataContext.GetTable<Product>()
                          select data).Take(10).OrderBy(m=>m.Name);
                pvm.products = products.ToList();
                pvm.productCount = products.Count();
                
            }

            return View(pvm);
        }

        //Default Attribute is Httpget
        // api/Home/GetDateTime
        public JsonResult GetDateTime()
        {
            DateTime dt = DateTime.Now;
            string datetime = dt.ToLongDateString();
            return Json(datetime);
        }
    }
}
