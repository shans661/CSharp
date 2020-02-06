using Builder.Features;
using Builder.Features.Vehicles;
using Builder.Interfaces;
using System;

namespace Builder
{
    class Shop
    {
        public void Construct(IVehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildDoors();
            vehicleBuilder.BuildWheels();
        }
    }
}
