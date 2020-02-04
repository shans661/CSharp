using AbstractFactory.Features.Animals.Carnivore;
using AbstractFactory.Features.Animals.Herbivore;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Features.Continets
{
    //Concrete continent factory - Europe
    class EuropeContinent : IContinentFactory
    {
        public EuropeContinent()
        {
            Console.WriteLine("Europe Continent created");
        }
        //Method to create carnivore -  Product A2
        public ICarnivore CreateCarnivore()
        {
            // Returns actual animal
            return new Tiger();
        }

        //Method to create herbivore - Product B2
        public IHerbivore CreateHerbivore()
        {
            // Returns actual animal
            return new Wildebeest();
        }
    }
}
