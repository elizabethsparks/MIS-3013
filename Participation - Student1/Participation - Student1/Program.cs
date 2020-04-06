using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation___Student1
{
    class Program
    {
        static void Main(string[] args)
        {//worked with Dee Fogel and Riley Carr
            Student Student1 = new Student();
            Student1.FirstName = "Elizabeth";
            Student1.LastName = "Sparks";

            Student1.CourseNames.Add("MIS3013");
            Student1.CourseGrades.Add("A");

            Student1.CalculateGPA();

            Console.ReadKey();

        }
    }
}
