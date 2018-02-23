using System;
using FactoryPattern.Code.AbstractFactory.Interfaces;

namespace FactoryPattern.Code.AbstractFactory
{
    public class TeaFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"Tea is preparing {amount} ml");
            return new Tea();
        }
    }
}