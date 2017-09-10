using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DomainLogic;
using Products_Correct_DI.Models;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository repository;

        public HomeController(IProductRepository repository)
        {
            if (repository == null)
            {
                throw new ArgumentNullException("repository");
            }

            this.repository = repository;
        }

        public ActionResult Index()
        {
            var productService = new ProductService(this.repository);

            var vm = new FeaturedProductsViewModel();
            var products = productService.GetFeauturedProducts(this.User);
            foreach (var product in products)
            {
                var productVM = new ProductViewModel(product);
                vm.Products.Add(productVM);
            }

            return View(vm);
        }
    }
}













