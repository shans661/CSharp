using Composite.Features;
using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------");
            //Create composite element

            CompositeElement root = new CompositeElement("Lines picture");
            root.Add(new PrimitiveElement("Blue Line"));
            root.Add(new PrimitiveElement("Black Line"));
            root.Add(new PrimitiveElement("White Line"));

            PrimitiveElement whiteCircle = new PrimitiveElement("White circle");
            whiteCircle.Add(new PrimitiveElement("Circle"));
            whiteCircle.Display();

            CompositeElement circles = new CompositeElement("Circles");
            circles.Add(whiteCircle);
            circles.Add(new PrimitiveElement("Blue Circle"));
            circles.Add(new PrimitiveElement("Orange Circle"));
            circles.Add(new PrimitiveElement("Gray Circle"));
            circles.Display();

            root.Add(circles);
            root.Display();
            Console.WriteLine("----------------------");

            root.Remove(circles);
            root.Display();

            Console.ReadKey();

        }
    }
}
