using FlyWeight.AbstarctClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeight.Features
{
    /// <summary>
    /// Concrete character B
    /// </summary>
    class CharacterB : Character
    {
        public CharacterB()
        {
            Name = "B";
            FontSize = 66;
            Width = 66;
            Height = 66;
            Console.WriteLine($"Charcter {Name} created");

        }
        public override void Display()
        {
            Console.WriteLine($"Name: {Name}, Font size: {FontSize}, Width: {Width}, Height: {Height}");
        }
    }
}
