using System;
using System.Collections.Generic;
using FactoryPattern.Code.AbstractFactory.Interfaces;

namespace FactoryPattern.Code.AbstractFactory
{
    public class HotDrinkMachine
    {

        #region Violates OCP

        //public enum AvaliableDrink
        //{
        //    Coffee, Tea
        //}

        //readonly Dictionary<AvaliableDrink, IHotDrinkFactory> factories = new Dictionary<AvaliableDrink, IHotDrinkFactory>();

        //public HotDrinkMachine()
        //{
        //    foreach (AvaliableDrink drink in Enum.GetValues(typeof(AvaliableDrink)))
        //    {
        //        var factory = (IHotDrinkFactory)Activator.CreateInstance(Type.GetType(
        //            "FactoryPattern.Code.AbstractFactory." + Enum.GetName(typeof(AvaliableDrink), drink) + "Factory"));
        //        factories.Add(drink, factory);
        //    }
        //}

        //public IHotDrink MakeDrink(AvaliableDrink drink, int amount)
        //{
        //    return factories[drink].Prepare(amount);
        //}

        #endregion

        #region OCP Validated version

        private List<Tuple<string, IHotDrinkFactory>> _factories = new List<Tuple<string, IHotDrinkFactory>>();

        public HotDrinkMachine()
        {
            foreach (var t in typeof(HotDrinkMachine).Assembly.GetTypes())
            {
                if (typeof(IHotDrinkFactory).IsAssignableFrom(t) && !t.IsInterface)
                {
                    _factories.Add(Tuple.Create(t.Name.Replace("Factory", string.Empty), (IHotDrinkFactory)Activator.CreateInstance(t)));
                }
            }
        }

        public IHotDrink MakeDrink()
        {
            Console.WriteLine("Available drinks: ");

            for (var index = 0; index < _factories.Count; index++)
            {
                var tuple = _factories[index];
                Console.WriteLine($"{index}: {tuple.Item1}");
            }

            while (true)
            {
                string s;
                var index = 0;

                if ((s = Console.ReadLine()) != null
                    && int.TryParse(s, out index)
                    && index >= 0
                    && index < _factories.Count)
                {
                    Console.WriteLine("Specify amount: ");
                    s = Console.ReadLine();

                    var result = 0;
                    if (s != null && int.TryParse(s, out result)
                                  && result > 0)
                    {
                        return _factories[index].Item2.Prepare(result);
                    }
                }
            }
        }

        #endregion

    }
}