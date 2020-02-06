using Prototype.Features;
using Prototype.Interface;
using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------");
            //Original Red color object
            Color m_RedColor = new Color("Red");
            m_RedColor.CreateColor(255, 0, 0, 0);
            m_RedColor.ShowColor();

            Console.WriteLine("--------------------------------");
            //Clone of the Red color
            Color m_RedColorDark = m_RedColor.Clone() as Color;
            m_RedColorDark.ColorName = "Red light";
            m_RedColorDark.CreateColor(244,0,155);
            m_RedColorDark.ShowColor();

            Console.ReadKey();
        }
    }
}
