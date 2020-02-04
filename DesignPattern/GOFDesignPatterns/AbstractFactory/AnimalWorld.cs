using AbstractFactory.Features.Continets;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    //Animal world
    class AnimalWorld
    {
        public static void Main(string[] args)
        {
            //Concrete class
            AsiaContinent asiaContinent = new AsiaContinent();
            //Using interface to create object
            ICarnivore lion = asiaContinent.CreateCarnivore();
            IHerbivore bison = asiaContinent.CreateHerbivore();

            lion.Eat(bison);

            //Concrete class
            EuropeContinent europeContinent = new EuropeContinent();
            //Using interface to create object
            ICarnivore tiger = europeContinent.CreateCarnivore();
            IHerbivore wildebeest = europeContinent.CreateHerbivore();

            tiger.Eat(wildebeest);
            tiger.Eat(bison);

            Console.ReadKey();
        }
    }
}
