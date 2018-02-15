using System;
using BuilderPattern.Code.Interfaces;

namespace BuilderPattern.Code.FluentVehicles
{
    public class FluentExcavator : IFluentVehicleBuilder
    {

        private string _name;
        private Guid _serialNumber;
        private int _maximumSpeed;

        public IFluentVehicleBuilder SetName(string name)
        {
            _name = name;
            return this;
        }

        public IFluentVehicleBuilder SetMaximumSpeed(int topSpeed)
        {
            _maximumSpeed = topSpeed;
            return this;
        }

        public IFluentVehicleBuilder SetSerialNumber(Guid serialNumber)
        {
            _serialNumber = serialNumber;
            return this;
        }
        public Vehicle BuildProduct()
        {
            Console.WriteLine($"{_name} created");

            return new Vehicle()
            {
                SerialNumber = _serialNumber.ToString(),
                MaximumSpeed = _maximumSpeed,
                Name = _name
            };
        }

    }
}