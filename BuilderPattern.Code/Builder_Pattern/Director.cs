using BuilderPattern.Code.Builder_Pattern.Interfaces;

namespace BuilderPattern.Code.Builder_Pattern
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