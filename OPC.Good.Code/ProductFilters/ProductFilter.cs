using System.Collections.Generic;
using OPC.Good.Code.Interfaces;
using OPC.Good.Code.Model;

namespace OPC.Good.Code.ProductFilters
{
    public class ProductFilter : IProductFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> specification)
        {
            foreach (var product in items)
                if (specification.IsSatisfied(product))
                    yield return product;
        }
    }
}
