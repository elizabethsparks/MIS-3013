using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Review
{
    class DaysIntheMonth
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What month is it?");
            string CurrentMonth = Console.ReadLine();

            if (CurrentMonth == "January")
            {
                Console.WriteLine("There are 31 days in the month.");
            }

            else if (CurrentMonth == "February")
            {
                    Console.WriteLine("Is it a leap year?");
                    string LeapYear = Console.ReadLine();

                    if (LeapYear == "yes")
                    {
                        Console.WriteLine("There are 29 days in the month.");
                    }
                    else
                    {
                        Console.WriteLine("There are 28 days in the month. ");
                    }
            }


            else if (CurrentMonth == "March")
            {
                Console.WriteLine("There are 31 days in the month.");
            }

            else if (CurrentMonth == "April")
            {
                Console.WriteLine("There are 30 days in the month.");
            }


            else if (CurrentMonth == "May")
            {
                Console.WriteLine("There are 31 days in the month.");
            }

            else if (CurrentMonth == "June")
            {
                Console.WriteLine("There are 30 days in the month.");
            }

            else if (CurrentMonth == "July")
            {
                Console.WriteLine("There are 31 days in the month.");
            }

            else if (CurrentMonth == "August")
            {
                Console.WriteLine("There are 31 days in the month.");
            }

            else if (CurrentMonth == "September")
            {
                Console.WriteLine("There are 31 days in the month.");
            }

            else if (CurrentMonth == "October")
            {
                Console.WriteLine("There are 31 days in the month.");
            }

            else if (CurrentMonth == "November")
            {
                Console.WriteLine("There are 30 days in the month.");
            }

            else if (CurrentMonth == "Decebmer")
            {
                Console.WriteLine("There are 31 days in the month.");
            }



            Console.ReadKey();

        }
    }
}
