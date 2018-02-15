using BuilderPattern.Code.Interfaces;

namespace BuilderPattern.Code
{
    public class Director
    {

        public void CreateVehicle(IVehicleBuilder builder)
        {
            builder.SetName();
            builder.SetSerialNumber();
            builder.SetMaximumSpeed();
        }

    }
}