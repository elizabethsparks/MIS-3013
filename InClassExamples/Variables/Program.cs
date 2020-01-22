//Elizabeth Sparks
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a string named firstName
            string firstName;

            //Assign a value to firstName (Elizabeth Sparks)
            firstName = "Elizabeth";

            //Create an integer named favoriteNumber and assign your favorite number to it
            int favoriteNumber = 13;

            double crazyNumber = 7.6767 * favoriteNumber;

            string lastName = "Sparks";
            string fullName = firstName + " " + lastName;


            Console.WriteLine(fullName + " has the favorite number of " + favoriteNumber 
                + " \nwhich equates to a crazy number of " + crazyNumber);

            // MAKE IT DYNAMIC


            Console.ReadKey();
        }
    }
}
