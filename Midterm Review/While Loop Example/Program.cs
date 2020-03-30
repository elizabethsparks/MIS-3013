using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> AllNumbers = new list<double>();
            Console.WriteLine("Please enter a number");
            string usersAnswerAsString = Console.ReadLine();
            double usersAnswersAsdouble = Convert.ToDouble(usersAnswerAsString);
            AllNumbers.Add(usersAnswersAsdouble);

            Console.WriteLine("Do you want to enter another number?");
            string enterAnotherNumber = Console.ReadLine();

            while (enterAnotherNumber == "yes")
            {
                
                Console.WriteLine("Please enter a number");
                string usersAnswerAsString = Console.ReadLine();
                double usersAnswersAsdouble = Convert.ToDouble(usersAnswerAsString);
                AllNumbers.Add(usersAnswersAsdouble);

                Console.WriteLine("Do you want to enter another number?");
                string enterAnotherNumber = Console.ReadLine();
            }

        }
    }
}
