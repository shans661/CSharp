using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeight.AbstarctClass
{
    /// <summary>
    /// Abstract class
    /// </summary>
    abstract class Character
    {
        public string Name { get; set; }
        public int FontSize { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Display();
    }
}
