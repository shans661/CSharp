using Builder.Features.Vehicles;
using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Features
{
    //Bike is complex object created in steps
    class BikeBuilder : IVehicleBuilder
    {
        Vehicle m_Vehicle;
        public BikeBuilder(Vehicle vehicle)
        {
            m_Vehicle = vehicle;
        }
        public void BuildDoors()
        {
            m_Vehicle.VehicleParts["Doors"] = "No door for bike";
        }

        public void BuildEngine()
        {
            m_Vehicle.VehicleParts["Engine"] = $"{m_Vehicle.Brand + m_Vehicle.Model} engine attached";
        }

        public void BuildFrame()
        {
            m_Vehicle.VehicleParts["Frame"] = $"{m_Vehicle.Brand + m_Vehicle.Model} frame attached";
        }

        public void BuildWheels()
        {
            m_Vehicle.VehicleParts["Wheels"] = $"{m_Vehicle.Brand + m_Vehicle.Model} wheels attached";
        }
    }
}
