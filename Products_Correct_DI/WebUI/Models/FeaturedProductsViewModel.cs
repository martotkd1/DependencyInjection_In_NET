using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DomainLogic;

namespace Products_Correct_DI.Models
{
    public class FeaturedProductsViewModel
    {
        public FeaturedProductsViewModel() 
        {
            Products = new List<ProductViewModel>();
        }

        public List<ProductViewModel> Products { get; set; }
    }
}