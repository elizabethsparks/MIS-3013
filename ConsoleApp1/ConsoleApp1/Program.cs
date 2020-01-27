using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your fist name>>");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your favorite number >>");
            string FavNumberAsstring = Console.ReadLine();
            int favNumber = Convert.ToInt32(FavNumberAsstring);
            //combine 2 steps into 1: int favNumber = Convert.ToInt32(Console.ReadLine());

            int favNumberTimes10 = 10 * favNumber;

            string message = firstName + " you have a favorite number of " + favNumber.ToString("N3") + " and if you multiply that by 10 you get "
            + favNumberTimes10.ToString("N3");


            if (favNumber == 7 || favNumber == 3)

            {
                Console.WriteLine("How original are you?");
            }

            if(favNumber == 13)
            {
                else
                
                Console.WriteLine("What? That is an unlucky #");{


                    Console.WriteLine(message);
                }

               if (favNumber % 2 ==0)

                {
                    Console.WriteLine("your number is even");

                }

            }



            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
