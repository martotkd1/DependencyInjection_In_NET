using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace DomainLogic
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetFeaturedProducts(IPrincipal user);
    }
}