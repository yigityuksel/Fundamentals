using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Code.FluentVehicles;
using BuilderPattern.Code.Vehicles;

namespace BuilderPattern.Code
{
    class Program
    {
        static void Main(string[] args)
        {

            var director = new Director();

            director.CreateVehicle(new Car());

            director.CreateVehicle(new Excavator());

            var _excavator = new FluentExcavator().SetMaximumSpeed(30).SetName("Fluent Excavator").SetSerialNumber(Guid.NewGuid()).BuildProduct();


            var _car = new FluentCar().SetMaximumSpeed(250).SetName("Fluent Car")
                .SetSerialNumber(Guid.NewGuid()); //works without build call, check code.



        }
    }
}
