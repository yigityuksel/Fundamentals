using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Good.Example.Interfaces
{
    public interface IInterestCalculator
    {
        decimal CalculateInterest(IBankAccount bankAccount);
    }
}
