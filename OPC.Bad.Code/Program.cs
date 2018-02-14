using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPC.Bad.Code
{
    class Program
    {
        static void Main(string[] args)
        {

            var desk = new Product("Desk", Size.Medium, Color.Yellow);
            var car = new Product("Car", Size.Large, Color.Yellow);
            var tv = new Product("Tv", Size.Medium, Color.Green);

            Product[] products = { desk, car, tv };

            var productFilter = new ProductFilter();

            foreach (var product in productFilter.FilterByColor(products,Color.Yellow))
            {
                Console.WriteLine($" - {product.Name} color is Yellow");
            }

            foreach (var product in productFilter.FilterBySize(products, Size.Medium))
            {
                Console.WriteLine($" - {product.Name} size is Medium");
            }
            
            #region PreventClose

            if (!Debugger.IsAttached) return;
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadLine();

            #endregion

        }
    }
}
