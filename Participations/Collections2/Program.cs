using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elizabeth Sparks

            //Question 1

            double[] CourseNumber = new double[3];
            string[] CourseName = new string[3];

            for (int i = 0; i < CourseNumber.Length; i++)
            {
                Console.WriteLine("Please input a coursename");
                CourseName[i] = Console.ReadLine();
                Console.WriteLine("Please input a coursenumber");
                CourseNumber[i] = Convert.ToDouble(Console.ReadLine());
            }

            

            for (int i = 0; i < CourseNumber.Length; i++)
            {
                Console.WriteLine($"Course with name {CourseName[i]} has a number of {CourseNumber[i]}");
            }

            //Question 2
            List<double> GradesList = new List<double>();
            string Answer;
            

            do
            {
                Console.WriteLine("Enter your Grade.");
                double Grade = Convert.ToDouble(Console.ReadLine());
                GradesList.Add(Grade);

                Console.WriteLine("Do you want to enter another exam grade?");
                Answer = Console.ReadLine();
            } while (Answer == "yes");

            double Sum = 0;
            foreach (var Grade in GradesList)
            {
                Sum = Sum + GradesList[i];
            }


            Console.ReadKey();
        }
    }
}
