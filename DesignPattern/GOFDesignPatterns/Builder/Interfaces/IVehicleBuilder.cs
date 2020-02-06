using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Interfaces
{
    //Interface to create the complex object
    interface IVehicleBuilder
    {
        //Create frame of the veicle
        void BuildFrame();

        //Create engine of the vehicle
        void BuildEngine();

        //Create doors of the vehicle
        void BuildDoors();

        //Create wheels of the vehicle
        void BuildWheels();
    }
}
