using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Bad.Example
{
    public class BankAccount
    {
        /// <summary>
        /// This code breaks SRP, because BankAccount class has multiple responsibilities.
        /// </summary>

        public string AccountName { get; set; }

        public double AccountBalance { get; set; }

        public decimal CalculateInterest()
        {
            //calculation Logic.

            return 0;
        }

    }
}
