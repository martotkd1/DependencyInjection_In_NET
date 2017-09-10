using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogic
{
    public class Product
    {
        public string Name { get; set; }
        
        public decimal UnitPrice { get; set; }

        public DiscountedProduct ApplyDiscountsFor(IPrincipal user)
        {
            var discountedProduct = new DiscountedProduct();
            discountedProduct.Name = Name;

            bool isPreferredCustomer = user.IsInRole("PreferredCustomer");
            var discount = (isPreferredCustomer) ? .95m : 1;
            discountedProduct.UnitPrice = UnitPrice * discount;

            return discountedProduct;
        }
    }
}
