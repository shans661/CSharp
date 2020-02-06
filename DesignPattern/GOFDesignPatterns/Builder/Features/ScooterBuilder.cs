using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Features
{
    //Scooter is complex object created in steps
    class ScooterBuilder : IVehicleBuilder
    {
        public void BuildDoors()
        {
            throw new NotImplementedException();
        }

        public void BuildEngine()
        {
            throw new NotImplementedException();
        }

        public void BuildFrame()
        {
            throw new NotImplementedException();
        }

        public void BuildWheels()
        {
            throw new NotImplementedException();
        }
    }
}
