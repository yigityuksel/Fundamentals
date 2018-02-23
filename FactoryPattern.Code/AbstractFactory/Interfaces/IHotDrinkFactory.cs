namespace FactoryPattern.Code.AbstractFactory.Interfaces
{
    public interface IHotDrinkFactory
    {
        IHotDrink Prepare(int amount);
    }
}