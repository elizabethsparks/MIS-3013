using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a type of animal: (cow, dog, or pig)");
            string animal = Console.ReadLine();
            string sound = "";
            sound = Speak(animal);

            Console.WriteLine(sound);
            Console.ReadKey();
        }

        static string Speak (string animal)
        {
            string sound = "";
            if (animal == "cow")
            {
                sound = "moo";
                return sound;
            }
            else if (animal == "dog")
            {
                sound = "bark";
                return sound;
            }
           else if (animal == "pig")
            {
                sound = "oink";
                return sound;
            }
            else
            {
                Console.WriteLine("Sorry, enter a different animal.");
                
            }
            return sound;

        }


        



        
    }
}
