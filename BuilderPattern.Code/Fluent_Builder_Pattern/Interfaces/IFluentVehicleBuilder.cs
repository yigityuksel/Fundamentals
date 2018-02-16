using System;
using BuilderPattern.Code.Models;

namespace BuilderPattern.Code.Fluent_Builder_Pattern.Interfaces
{
    public interface IFluentVehicleBuilder
    {
        IFluentVehicleBuilder SetName(string name);

        IFluentVehicleBuilder SetMaximumSpeed(int topSpeed);

        IFluentVehicleBuilder SetSerialNumber(Guid serialNumber);

        Vehicle BuildProduct();
    }
}