using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Code.Models
{
    public class User
    {
        public override string ToString()
        {
            return $"{nameof(Address)}: {Address}, {nameof(PostCode)}: {PostCode}, {nameof(PhoneNumber)}: {PhoneNumber}, {nameof(CompanyName)}: {CompanyName}, {nameof(Position)}: {Position}, {nameof(AnnualIncome)}: {AnnualIncome}";
        }

        //address info
        public string Address, PostCode, PhoneNumber;

        //works info
        public string CompanyName, Position;
        public int AnnualIncome;

    }
}
