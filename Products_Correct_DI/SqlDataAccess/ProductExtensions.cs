using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataAccess
{
    public static class ProductExtensions
    {
        public static DomainLogic.Product ToDomainProduct(this Product product)
        {
            var productDomain = new DomainLogic.Product();
            productDomain.Name = product.Name;
            productDomain.UnitPrice = (product.UnitPrice == null) ? 0 : (decimal)product.UnitPrice;
            return productDomain;
        }
    }
}