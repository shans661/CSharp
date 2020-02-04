using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Features.Animals.Carnivore
{
    //Carnivore Lion
    class Lion : ICarnivore
    {
        public void Eat(IHerbivore herbivore)
        {
            Console.WriteLine($"Lion eats {herbivore.GetType().Name}");
        }
    }
}
