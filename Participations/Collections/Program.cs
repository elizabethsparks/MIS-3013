using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> ExamGrades = new List<double>();
            string Answer;

            do
            {
                Console.WriteLine("Enter your Exam Grade.");
                double ExamGrade = Convert.ToDouble(Console.ReadLine());
                ExamGrades.Add(ExamGrade);

                Console.WriteLine("Do you want to enter another exam grade?");
                Answer = Console.ReadLine();
            } while (Answer=="yes");

            double Sum = 0;
            double Min = -1;
            double Max = 100;

            for (int i = 0; i < ExamGrades.Count; i++)
            {
                Sum = Sum + ExamGrades[i];
            }
            Console.WriteLine($"Your total is {Sum}");
            double Average = Sum / ExamGrades.Count;
            Console.WriteLine($"Your Average for your exams are {Average}");

            for (int i = 0; i < ExamGrades.Count; i++)
            {
                if (ExamGrades[i] > ExamGrades[i])
                {
                    Console.WriteLine($"Your maximum grade is {ExamGrades[i]}");
                }
            }

            Console.WriteLine($"Your max grade is {ExamGrades.Max()}");
            
            

            Console.ReadKey();
        }
    }
}
