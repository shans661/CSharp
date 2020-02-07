using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Features
{
    /// <summary>
    /// Adapter converts chemical compound database data into Compound
    /// </summary>
    class RichCompound : Compund
    {
        ChemicalDataBase m_ChemicalDataBase = new ChemicalDataBase();
        public RichCompound(string name) : base(name)
        {
        }

        /// <summary>
        /// This method converts GetCompound type to display compound
        /// </summary>
        public override void Display()
        {
            base.Display();
            var compound = m_ChemicalDataBase.GetCompund(Name);

            Console.WriteLine($"Compound formula : {compound.Formula}");
            Console.WriteLine($"Compound meltingpoint : {compound.MeltingPoint}");
            Console.WriteLine($"Compound boiling point : {compound.BoiingPoint}");

        }
    }
}
