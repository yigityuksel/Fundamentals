using FactoryPattern.Code.AbstractFactory;

namespace FactoryPattern.Code
{
    class Program
    {
        static void Main(string[] args)
        {

            //p1
            //var machine = new HotDrinkMachine();
            //var drink = machine.MakeDrink(HotDrinkMachine.AvaliableDrink.Tea, 100);
            //drink.Consume();


            //p2
            var machine = new HotDrinkMachine();
            machine.MakeDrink();

        }
    }
}



