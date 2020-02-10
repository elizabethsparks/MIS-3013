using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //                  01234...
            string firstName = "Elizabeth";
            string lastName = "Sparks";


            Console.WriteLine($"You have {firstName.Length.ToString("NO")} characters in your first name.");
            Console.WriteLine($"You have {lastName.Length.ToString("NO")} characters in your last name.");
            char firstInitial = firstName[0];
            char lastInitial = lastName[0];

            //Console.WriteLine(firstName.ToUpper()[0]);
            //Console.WriteLine(firstName.ToUpper()[1]);
            //Console.WriteLine(firstName.ToUpper()[2]);
            //Console.WriteLine(firstName.ToUpper()[3]);

            firstName = firstName.ToUpper();

            for (int i = 0; i < firstName.Length; i++)
            {
                char currentLetter = firstName[i];
                Console.WriteLine(currentLetter);
            }

            Console.WriteLine("Output every other letter of the first name");
            for (int i = 0; i < firstName.Length; i = i + 2)
            {
                char currentLetter = firstName[i];
                Console.WriteLine(currentLetter + " ");
            }

            Console.WriteLine();
            Console.WriteLine($"Your initials are {firstInitial}.{lastInitial}");


            //Elizabeth Sparks
            //Skraps Htebazile


            string name = firstName + " " + lastName;

            string fName = name.Substring(0, firstName.Length);
            var pieces = name.Split(' '); //Creates a collection with a size of 2
            fName = "        " + fName + "       ";
            fName = fName.Trim();
            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i]);
            }




            Console.ReadKey();
        }
    }
}
