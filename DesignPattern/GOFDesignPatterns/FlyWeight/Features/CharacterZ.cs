using FlyWeight.AbstarctClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeight.Features
{
    /// <summary>
    /// Concrete character Z
    /// </summary>
    class CharacterZ : Character
    {
        public CharacterZ()
        {
            Name = "Z";
            FontSize = 99;
            Width = 99;
            Height = 99;
            Console.WriteLine($"Charcter {Name} created");

        }
        public override void Display()
        {
            Console.WriteLine($"Name: {Name}, Font size: {FontSize}, Width: {Width}, Height: {Height}");
        }
    }
}
