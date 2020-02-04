using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Interfaces
{
    //Interface of absract factory
    interface IContinentFactory
    {
        //Interface to create carnivore
        ICarnivore CreateCarnivore();

        //Interface to create herbivore
        IHerbivore CreateHerbivore();
    }
}
