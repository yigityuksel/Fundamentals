using System;
using BuilderPattern.Code.Interfaces;

namespace BuilderPattern.Code.Vehicles
{
    public class Excavator : IVehicleBuilder
    {
        private readonly Vehicle _vehicle = new Vehicle();

        public void SetName()
        {
            _vehicle.Name = "Excavator";
            Console.WriteLine($"{_vehicle.Name} has builded");
        }

        public void SetSerialNumber()
        {
            _vehicle.SerialNumber = Guid.NewGuid().ToString();
            Console.WriteLine($"The {_vehicle.Name} serial number is {_vehicle.SerialNumber}");
        }

        public void SetMaximumSpeed()
        {
            _vehicle.MaximumSpeed = 10;
            Console.WriteLine($"Maximum speed of {_vehicle.Name} is {_vehicle.MaximumSpeed} km/h");
        }

        public Vehicle BuildProduct()
        {
            return _vehicle;
        }
    }
}