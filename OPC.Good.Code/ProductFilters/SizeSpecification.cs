using OPC.Good.Code.Interfaces;
using OPC.Good.Code.Model;

namespace OPC.Good.Code.ProductFilters
{
    public class SizeSpecification : ISpecification<Product>
    {
        private readonly Size _size;

        public SizeSpecification(Size size)
        {
            _size = size;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Size == _size;
        }
    }
}
