using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DomainLogic;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {                        
            var service = new ProductService();
            bool isPreferredCustomer = this.User.IsInRole("PreferredCustomer");
            var products = service.GetFeaturedProducts(isPreferredCustomer);
            this.ViewData["Products"] = products;

            return View();
        }        
    }
}
