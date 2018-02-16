using System;
using BuilderPattern.Code.Builder_Pattern.Interfaces;
using BuilderPattern.Code.Models;

namespace BuilderPattern.Code.Builder_Pattern.Vehicles
{
    public class Car : IVehicleBuilder
    {

        private readonly Vehicle _vehicle = new Vehicle();

        public void SetName()
        {
            _vehicle.Name = "Car";
            Console.WriteLine($"{_vehicle.Name} has builded");
        }

        public void SetSerialNumber()
        {
            _vehicle.SerialNumber = Guid.NewGuid().ToString();
            Console.WriteLine($"The {_vehicle.Name} serial number is {_vehicle.SerialNumber}");
        }

        public void SetMaximumSpeed()
        {
            _vehicle.MaximumSpeed = 200;
            Console.WriteLine($"Maximum speed of {_vehicle.Name} is {_vehicle.MaximumSpeed} km/h");
        }

        public Vehicle BuildProduct()
        {
            return _vehicle;
        }

    }
}
