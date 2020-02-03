using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            //use the next method on 'rand' and pass in 0,2 to generate a random number that is 0 or 1
            int randomNumber = 0;
            int usersGuess = 0;

            while (usersGuess != randomNumber)
            {

                randomNumber = rand.Next(0, 2);
                Console.WriteLine(randomNumber);


                Console.WriteLine("Enter Heads or Tails >>");
                string usersGuessAsString = Console.ReadLine();
                
                const int HEADS_Value = 0;
                const int TAILS_VALUE = 1;


                if (usersGuessAsString == "Heads");
                else if (usersGuessAsString == "Tails");
                else; 
                

            }




             Console.ReadKey();
        }

}
   
    } 
