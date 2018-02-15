using ISP.Good.Code.Interfaces;

namespace ISP.Good.Code.Machines
{
    public class OldFashionedPrinter : IPrint
    {
        /// <summary>
        /// Old fashioned printer just prints, no other implements are required.
        /// </summary>

        public void Print()
        {
            throw new System.NotImplementedException();
        }
    }
}