using System;
using FactoryPattern.Code.AbstractFactory.Interfaces;

namespace FactoryPattern.Code.AbstractFactory
{
    public class Coffee : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine($"This coffee is purrffecct");
        }
    }
}