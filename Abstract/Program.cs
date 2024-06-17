using Abstract;
using System;

namespace ShapeArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape myCircle = new Circle(10.0);
            Shape myRectangle = new Rectangle(10.0, 5.0);

            Console.WriteLine($"Area of Circle: {myCircle.GetArea()}");
            Console.WriteLine($"Area of Rectangle: {myRectangle.GetArea()}");
        }
    }
}