using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Code.Facaded_Builder_Pattern;
using BuilderPattern.Code.Models;

namespace BuilderPattern.Code
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Builder

            //var director = new Director();

            //director.CreateVehicle(new Car());

            //director.CreateVehicle(new Excavator());

            #endregion

            #region FluentBuilder

            //var _excavator = new FluentExcavator().SetMaximumSpeed(30).SetName("Fluent Excavator").SetSerialNumber(Guid.NewGuid()).BuildProduct();

            //var _car = new FluentCar().SetMaximumSpeed(250).SetName("Fluent Car")
            //    .SetSerialNumber(Guid.NewGuid()); //works without build call, check code.

            #endregion

            #region FluentBuilder with Recursive

            //var builder = new PersonJobBuilder();
            //builder.Called("yigit").WorksAsA => we couldn't call,

            //var person = Person.New.Called("yiğit").WorksAsA("engineer").Build();

            //Console.WriteLine(person);

            #endregion

            #region Facaded_Builder_Pattern

            var userBuilder = new UserBuilder();

            User user = userBuilder
                .Lives
                    .At("Muğla")
                    .WithPhoneNumber("25255")
                    .WithPostCode("48000")
                .Works
                    .At("Com")
                    .As("engineer")
                    .Income(1560);

            Console.WriteLine(user);

            #endregion

        }
    }
}



