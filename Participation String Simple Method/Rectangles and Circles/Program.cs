using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles_and_Circles
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle Rect1 = new Rectangle();
            Rect1.Length = 5;
            Rect1.Width = 6;
         
            Rectangle Rect2 = new Rectangle();
            Rect2.Length = 3;
            Rect2.Width = 5;

            Console.WriteLine($"The area of the first rectangle is {Rect1.CalculateArea()}" );
            Console.WriteLine($"The area of the first rectangle is {Rect1.CalculatePerimeter()}");
            Console.WriteLine($"The area of the second rectangle is {Rect2.CalculateArea()}");
            Console.WriteLine($"The area of the second rectangle is {Rect2.CalculatePerimeter()}");

            Circle Circ1 = new Circle();
            Circ1.Radius = 4;

            Circle Circ2 = new Circle();
            Circ2.Radius = 6;

            Console.WriteLine($"The area of the first circle is {Circ1.CalculateCircArea()}");
            Console.WriteLine($"The area of the first circle is {Circ1.CalculateCircumference()}");
            Console.WriteLine($"The area of the second circle is {Circ2.CalculateCircArea()}");
            Console.WriteLine($"The area of the second circle is {Circ2.CalculateCircumference()}");

            Console.ReadKey();
        }
    }
}
