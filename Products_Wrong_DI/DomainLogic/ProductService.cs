using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlDataAccess;

namespace DomainLogic
{
    public class ProductService
    {
        private readonly Database1Entities1 objectContext;
 
        public ProductService()
        {
            this.objectContext = new Database1Entities1();
        }

        public IEnumerable<Product> GetFeaturedProducts(bool isCustomerPreferred)
        {
            var discount = isCustomerPreferred ? .95m : 1;
            var products = (from p in this.objectContext.Products 
                            where p.IsFeatured 
                            select p).AsEnumerable();
            return from p in products
                   select new Product
                   {
                       ProductId = p.ProductId,
                       Name = p.Name,
                       Description = p.Description,
                       IsFeatured = p.IsFeatured,
                       UnitPrice = p.UnitPrice * discount
                   };
        }
    }
}