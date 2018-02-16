using BuilderPattern.Code.Models;

namespace BuilderPattern.Code.Builder_Pattern.Interfaces
{
    public interface IVehicleBuilder
    {

        void SetName();

        void SetMaximumSpeed();

        void SetSerialNumber();

        Vehicle BuildProduct();

    }
}