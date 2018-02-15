using System;

namespace BuilderPattern.Code.Interfaces
{
    public interface IFluentVehicleBuilder
    {
        IFluentVehicleBuilder SetName(string name);

        IFluentVehicleBuilder SetMaximumSpeed(int topSpeed);

        IFluentVehicleBuilder SetSerialNumber(Guid serialNumber);

        Vehicle BuildProduct();
    }
}