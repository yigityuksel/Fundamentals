using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRP.Good.Example.Interfaces;

namespace SRP.Good.Example.BankAccount
{
    public class BankAccount : IBankAccount
    {
        public string AccountName { get; set; }
        public decimal AccountBalance { get; set; }



    }
}
