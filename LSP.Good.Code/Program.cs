using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Good.Code
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Quadrilaterals>();
            var exampleRectangle = new Rectangle() { Height = 10, Width = 15 };
            var exampleSquare = new Square() { Side = 10 };

            list.Add(exampleSquare);
            list.Add(exampleRectangle);

            foreach (var quadrilateralse in list)
            {
                Console.WriteLine(
                    $"{quadrilateralse.GetType().ToString()} rectangle area is {quadrilateralse.CalculateArea()}");
            }

            #region PreventClose

            if (!Debugger.IsAttached) return;
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadLine();

            #endregion

        }
    }
}
