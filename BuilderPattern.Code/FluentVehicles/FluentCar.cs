using System;
using BuilderPattern.Code.Interfaces;

namespace BuilderPattern.Code.FluentVehicles
{
    public class FluentCar : IFluentVehicleBuilder
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
            return new Vehicle()
            {
                SerialNumber = _serialNumber.ToString(),
                MaximumSpeed = _maximumSpeed,
                Name = _name
            };
        }

        /// <summary>
        /// works without calling build function, creates the object.
        /// </summary>
        /// <param name="fluentCar"></param>
        public static implicit operator Vehicle(FluentCar fluentCar)
        {

            Console.WriteLine($"{fluentCar._name} created without build called.");

            return new Vehicle()
            {
                SerialNumber = fluentCar._serialNumber.ToString(),
                MaximumSpeed = fluentCar._maximumSpeed,
                Name = fluentCar._name
            };
        }

    }
}