using Prototype.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Features
{
    /// <summary>
    /// Creates concrete color
    /// </summary>
    class Color : IColor
    {
        public Color(string color)
        {
            ColorName = color;
        }

        public string ColorName { get; set; }
        public int R { get; private set; }
        public int G { get; private set; }
        public int B { get; private set; }
        public int A { get; private set; }

        /// <summary>
        /// Clones the color
        /// </summary>
        /// <returns></returns>
        public IColor Clone()
        {
            return this.MemberwiseClone() as IColor;
        }

        public void CreateColor(int r=0, int g=0, int b=0, int a=0)
        {
            R = r;
            G = g;
            B = b;
            A = a;
        }

        public void ShowColor()
        {
            Console.WriteLine($"Color name: {ColorName}");
            Console.WriteLine($"R value: " + R);
            Console.WriteLine($"G value: " + G);
            Console.WriteLine($"B value: " + B);
            Console.WriteLine($"A value: " + A);
        }
    }
}
