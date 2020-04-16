using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private string Aisle { get; set; }
        public Toy()
        {
            Manufacturer = ""; Name = ""; Price = 0; Aisle = "";
        }
        public string GetAisle()
        {
            Random RandomNum = new Random();
            int RandomNumber = RandomNum.Next(1, 24);

            return Manufacturer.First().ToString().ToUpper();
        }
        public string GetAisle2()
        {
            Random RandomNum = new Random();
            int RandomNumber = RandomNum.Next(1, 24);
            return RandomNumber.ToString();
        }
    }
}
