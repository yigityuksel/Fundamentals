using System;
using ISP.Bad.Code.Interfaces;

namespace ISP.Bad.Code.Machines
{
    public class OldFashionedPrinter : IMachine
    {
        /// <summary>
        /// however, this printer can just print, other functions should not available for it.
        /// So in this case we have to seperate functionalities !.
        /// </summary>

        public void Print()
        {
            throw new NotImplementedException();
        }

        public void Scan()
        {
            throw new NotImplementedException();
        }

        public void Fax()
        {
            throw new NotImplementedException();
        }
    }
}
