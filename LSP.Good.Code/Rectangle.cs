using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Good.Code
{
    public class Rectangle : Quadrilaterals
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public override int CalculateArea()
        {
            return Height * Width;
        }
    }
}
