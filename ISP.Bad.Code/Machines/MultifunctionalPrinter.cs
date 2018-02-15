using ISP.Bad.Code.Interfaces;

namespace ISP.Bad.Code.Machines
{
    public class MultifunctionalPrinter : IMachine
    {
        /// <summary>
        /// the machine that can do all of things.
        /// </summary>

        public void Print()
        {
            throw new System.NotImplementedException();
        }

        public void Scan()
        {
            throw new System.NotImplementedException();
        }

        public void Fax()
        {
            throw new System.NotImplementedException();
        }
    }
}