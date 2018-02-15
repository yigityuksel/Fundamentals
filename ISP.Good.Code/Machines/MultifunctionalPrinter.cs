using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISP.Good.Code.Interfaces;

namespace ISP.Good.Code.Machines
{
    public class MultifunctionalPrinter : IFax, IPrint, IScan
    {

        /// <summary>
        /// So we separeted the functionalities, concrete classes can easily implement the required features. We wont implement non-required functionalites.
        /// </summary>

        public void Fax()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public void Scan()
        {
            throw new NotImplementedException();
        }
    }
}
