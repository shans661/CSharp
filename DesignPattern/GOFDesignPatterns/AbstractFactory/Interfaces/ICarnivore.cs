using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Interfaces
{
    //Interface to create cernovore
    interface ICarnivore
    {
        //Method to eat carnivore
        void Eat(IHerbivore herbivore);
    }
}
