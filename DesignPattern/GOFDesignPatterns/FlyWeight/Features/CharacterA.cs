using FlyWeight.AbstarctClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeight.Features
{
    /// <summary>
    /// Concrete character A
    /// </summary>
    class CharacterA : Character
    {
        public CharacterA()
        {
            Name = "A";
            FontSize = 33;
            Width = 33;
            Height = 33;
            Console.WriteLine($"Charcter {Name} created");
            
        }
        public override void Display()
        {
            Console.WriteLine($"Name: {Name}, Font size: {FontSize}, Width: {Width}, Height: {Height}");
        }
    }
}
