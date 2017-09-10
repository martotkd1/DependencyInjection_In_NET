using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using DomainLogic;

namespace SqlDataAccess
{
    public class SqlProductRepository : IProductRepository
    {
        private readonly Database1Entities1 context;

        public SqlProductRepository()
        {
            this.context = new Database1Entities1();
        }

        public IEnumerable<DomainLogic.Product> GetFeaturedProducts(IPrincipal user)
        {
            var products = this.context.Products.Where(p => p.IsFeatured).AsEnumerable();
            return products.Select(p => p.ToDomainProduct());
        }
    }
}