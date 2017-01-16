using System;
using System.Collections.Generic;

namespace SpreadEx
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>()
            {
                new Rectangle("Rectangle",new Point(10,10), 30,40),
                new Square("Square", new Point(15,30), 35),
                new Ellipse("Ellipse", new Point(100, 150), 300, 200),
                new Circle("Circle", new Point(1,1),300),
                new Textbox("Textbox", new Point(5,5), 200, 100, "sample text")
            };

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Requested Drawing");
            Console.WriteLine("--------------------------------------------------------------");

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }

            Console.Read();
        }
    }
}
