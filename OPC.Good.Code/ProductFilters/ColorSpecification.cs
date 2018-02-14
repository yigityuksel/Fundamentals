using OPC.Good.Code.Interfaces;
using OPC.Good.Code.Model;

namespace OPC.Good.Code.ProductFilters
{
    public class ColorSpecification : ISpecification<Product>
    {
        private readonly Color _color;

        public ColorSpecification(Color color)
        {
            _color = color;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Color == _color;
        }
    }
}
 