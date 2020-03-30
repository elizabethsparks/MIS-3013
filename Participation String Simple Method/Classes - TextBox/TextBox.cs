using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___TextBox
{
    class TextBox
    {//worked with Dee Fogel and Riley Carr
        public int padding { get; set; }
        public ConsoleColor backcolor { get; set; }
        public ConsoleColor forecolor { get; set; }
        public string text { get; set; }

        public TextBox()
        {
           

        }
        public void DisplayText()
        {
            Console.ForegroundColor = this.forecolor;
            Console.BackgroundColor = this.backcolor;
            string texttype = new string(' ',this.padding) + this.text + new string(' ', this.padding);
            Console.WriteLine(texttype);
        }
    }
}
