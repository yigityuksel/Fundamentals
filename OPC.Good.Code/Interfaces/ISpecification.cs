namespace OPC.Good.Code.Interfaces
{
    public interface ISpecification<T>
    {

        bool IsSatisfied(T t);

    }
}
