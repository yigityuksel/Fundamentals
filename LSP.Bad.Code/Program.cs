using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Bad.Code
{
    class Program
    {
        static void Main(string[] args)
        {

            var exampleRectangle = new Rectangle() {Height = 10, Width = 15};

            Console.WriteLine($"Rectangle area is  {exampleRectangle.CalculateArea()}");

            var exampleSquare = new Square() {Height = 10, Width = 10};

            Console.WriteLine($"Square area is {exampleSquare.CalculateArea()}");

            Rectangle exRectangle = new Square() {Height = 10 };

            //expected result is 150, but actual result is 100, so that means we couldnt use derived class as base class.
            Console.WriteLine($"Subsititued rectangle area is {exRectangle.CalculateArea()}");

            #region PreventClose

            if (!Debugger.IsAttached) return;
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadLine();

            #endregion

        }
    }
}
