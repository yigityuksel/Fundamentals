using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPC.Good.Code.Model;
using OPC.Good.Code.ProductFilters;

namespace OPC.Good.Code
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

            foreach (var product in productFilter.Filter(products, new ColorSpecification(Color.Yellow)))
                Console.WriteLine($" {product.Name} color is Yellow");

            foreach (var product in productFilter.Filter(products, new SizeSpecification(Size.Medium)))
                Console.WriteLine($" {product.Name} size is Medium");

            foreach (var product in productFilter.Filter(products, new AndSpecification(Size.Medium, Color.Green)))
                Console.WriteLine($" {product.Name} color is Green and size is Medium");

            #region PreventClose

            if (!Debugger.IsAttached) return;
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadLine();

            #endregion

        }
    }
}
