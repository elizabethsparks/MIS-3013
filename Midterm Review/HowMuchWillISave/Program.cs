using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowMuchWillISave
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much money do you want to save a week?");
            double WeeklySavings = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your Interest Rate? (If you don't have one, put 0)");
            double InterestRate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How many years do you want to save for?");
            double Years = Convert.ToDouble(Console.ReadLine());


            
            double AmountSavedPerMonth = (WeeklySavings * 4);
            double TotalAmountSaved = 0;// = AmountSavedPerMonth;

            for (int i = 1; i <= Years*12; i++)
            {
                TotalAmountSaved = (TotalAmountSaved + AmountSavedPerMonth) * (1 + InterestRate);
                Console.WriteLine(TotalAmountSaved);
            }

            Console.WriteLine(");

            Console.ReadKey();
        }
    }
}
