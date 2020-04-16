using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    class Program
    {
        static void Main(string[] args)
        {
            ToyBox ToyBox1 = new ToyBox();
            Toy Toy1 = new Toy();

            Toy1.Manufacturer = "Barbie";
            Toy1.Name = "Doctor Barbie";
            Toy1.Price = 14.99;
            Toy1.GetAisle();
            Toy1.GetAisle2();

            Console.WriteLine($"The manufacturer of Toy1 is {Toy1.Manufacturer}");
            Console.WriteLine($"The name of Toy1 is {Toy1.Name}");
            Console.WriteLine($"The price of Toy1 is {Toy1.Price}");
            Console.WriteLine($"Toy1 is found on Aisle {Toy1.GetAisle()} {Toy1.GetAisle2()}");

            Console.ReadKey();


        }
    }
}
