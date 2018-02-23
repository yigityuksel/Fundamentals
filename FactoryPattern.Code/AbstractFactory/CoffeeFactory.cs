using System;
using FactoryPattern.Code.AbstractFactory.Interfaces;

namespace FactoryPattern.Code.AbstractFactory
{
    public class CoffeeFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"Coffee is preparing {amount} ml");
            return new Coffee();
        }
    }
}