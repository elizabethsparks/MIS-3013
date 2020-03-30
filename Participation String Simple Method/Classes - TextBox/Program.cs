using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___TextBox
{
    class Program
    {
        static void Main(string[] args)
        {//worked with Dee Fogel and Riley Carr

            TextBox TextBox1 = new TextBox();
            TextBox1.backcolor = ConsoleColor.White;
            TextBox1.forecolor = ConsoleColor.Gray;
            TextBox1.padding = 2;
            TextBox1.text = "This is the first text box";

            TextBox TextBox2 = new TextBox();
            TextBox2.backcolor = ConsoleColor.Cyan;
            TextBox2.forecolor = ConsoleColor.Black;
            TextBox2.padding = 4;
            TextBox2.text = "This is the second text box";

            TextBox1.DisplayText();
            TextBox2.DisplayText();
            
            Console.ReadKey();
        }
    }
}
