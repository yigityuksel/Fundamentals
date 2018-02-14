using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPC.Good.Code.Interfaces;
using OPC.Good.Code.Model;

namespace OPC.Good.Code
{
    public class AndSpecification : ISpecification<Product>
    {
        private readonly Size _size;
        private readonly Color _color;

        public AndSpecification(Size size, Color color)
        {
            _size = size;
            _color = color;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Size == _size && t.Color == _color;
        }
    }
}
