using AbstractFactory.Features.Animals.Carnivore;
using AbstractFactory.Features.Animals.Herbivore;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Features.Continets
{
    //Concrete continent factory
    class AsiaContinent : IContinentFactory
    {
        public AsiaContinent()
        {
            Console.WriteLine("Asia continent created");
        }
        //Method to create carnivore - Product A1
        public ICarnivore CreateCarnivore()
        {
            Console.WriteLine($"Carnivore is created name is Lion");
            return new Lion();
        }

        //Method to create herbivore - Product B1
        public IHerbivore CreateHerbivore()
        {
            Console.WriteLine($"Herbivore is created name is Bison");
            return new Bison();
        }
    }
}
