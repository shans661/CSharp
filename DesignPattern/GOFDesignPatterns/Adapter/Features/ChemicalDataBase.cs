using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Features
{
    /// <summary>
    /// Adaptee - Chemical class will be converted into compound
    /// </summary>
    class ChemicalDataBase
    {
        Dictionary<string, Compund> m_Compounds;
        public ChemicalDataBase()
        {
            m_Compounds = new Dictionary<string, Compund>()
            {
                { "Water", new Compund("Water") {Formula="H2O", BoiingPoint=100, MeltingPoint = 10 } },
                { "Benzene", new Compund("Benzene") {Formula="C6H6", BoiingPoint=80, MeltingPoint = 20 } },
                { "Ethanol", new Compund("Ethanol") {Formula="C2H5OH", BoiingPoint=60, MeltingPoint = 30 } },
            };
        }

        public Compund GetCompund(string name)
        {
            switch(name)
            {
                case "Water":
                    return m_Compounds["Water"];
                case "Benzene":
                    return m_Compounds["Benzene"];
                case "Ethanol":
                    return m_Compounds["Ethanol"];
                default:
                    return new Compund("Default");
            }
        }
    }
}
