using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Good.Code
{
    public class Square : Quadrilaterals
    {
        public int Side { get; set; }

        public override int CalculateArea()
        {
            return Side * Side;
        }
    }
}
