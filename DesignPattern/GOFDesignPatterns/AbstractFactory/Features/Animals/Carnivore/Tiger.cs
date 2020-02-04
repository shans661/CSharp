using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Features.Animals.Carnivore
{
    //Carnivore tiger 1
    class Tiger : ICarnivore
    {
        public void Eat(IHerbivore herbivore)
        {
            Console.WriteLine($"Tiger eats {herbivore.GetType().Name}");
        }
    }
}
