using Builder.Features;
using Builder.Features.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------");

            //Create the vehicle with basic details
            Vehicle vehicle1 = new Vehicle("Honda", "Activa i");

            //Concrete vehicle of IVehicleBuilder
            BikeBuilder bike = new BikeBuilder(vehicle1);

            //Shop will create the complex vehicle creation step by step
            Shop shop = new Shop();
            shop.Construct(bike);

            //Once vehicle is ready it will show the deatils
            vehicle1.Show();

            Console.WriteLine("------------------------------------------------");

            Vehicle vehicle2 = new Vehicle("BMW", "Hybrid i10");

            //Concrete object of IVehicleBuilder
            CarBuilder car = new CarBuilder(vehicle2);

            //Shop will create the complex vehicle creation step by step
            shop.Construct(car);

            vehicle2.Show();

            Console.ReadKey();
        }
    }
}
