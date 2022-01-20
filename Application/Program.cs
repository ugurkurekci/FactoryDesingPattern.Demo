using Business.Example1;
using Business.Example2;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Application
{
    internal class Program
    {
        static void Main(string[] args)
        {


            VehicleFactory vehicleFactory = new ConcreteVehicleFactory();

            IFactory scooter = vehicleFactory.GetVehicle("Scooter");
            IFactory bike = vehicleFactory.GetVehicle("Bike");
            IFactory scootercolor = vehicleFactory.GetColor("Scooter");
            IFactory bikecolor = vehicleFactory.GetColor("Bike");

            scooter.Drive(20);
            scooter.Color("Red ");
            scootercolor.Drive(20);
            bikecolor.Color("Yellow ");
            Console.ReadLine();


        }
    }
}
