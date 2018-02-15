namespace BuilderPattern.Code.Interfaces
{
    public interface IVehicleBuilder
    {

        void SetName();

        void SetMaximumSpeed();

        void SetSerialNumber();

        Vehicle BuildProduct();

    }
}