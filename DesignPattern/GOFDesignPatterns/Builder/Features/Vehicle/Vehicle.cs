using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Features.Vehicles
{
    //
    class Vehicle
    {
       // Dictionary<string, string> VehicleParts;
        public Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;
            VehicleParts = new Dictionary<string, string>()
            {
                { "Engine", ""},
                {"Frame", "" },
                {"Wheels", "" },
                {"Doors", "" }
            };
        }
        public string Brand { get; set; }

        public string Model { get; set; }

        public Dictionary<string, string> VehicleParts { get; set; }

        internal void Show()
        {
            Console.WriteLine($"Brand name:{Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Parts");
            foreach(var item in VehicleParts)
            {
                Console.WriteLine($"{item.Key} + {item.Value}");
            }
        }
    }
}
