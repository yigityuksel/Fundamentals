using System;
using FactoryPattern.Code.AbstractFactory.Interfaces;

namespace FactoryPattern.Code.AbstractFactory
{
    public class Tea : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine($"This tea is awesome");
        }
    }
}