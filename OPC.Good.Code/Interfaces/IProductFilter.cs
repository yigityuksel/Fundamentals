using System.Collections.Generic;

namespace OPC.Good.Code.Interfaces
{
    public interface IProductFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> specification);
    }
}