using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DomainLogic;

namespace Products_Correct_DI.Models
{
    public class ProductViewModel
    {
        private readonly DiscountedProduct product;

        public ProductViewModel(DiscountedProduct product)
        {
            if (product == null)
            {
                throw new ArgumentNullException("product");
            }

            this.product = product;
        }

        public string Name
        {
            get
            {
                return product.Name;
            }
        }
                
        public string SummaryText 
        {
            get
            {
                return Name + " - " + UnitPrice.ToString();
            }
        }

        public decimal UnitPrice
        {
            get
            {
                return product.UnitPrice;
            }
        }
    }
}