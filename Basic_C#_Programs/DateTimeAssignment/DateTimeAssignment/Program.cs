using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current date and time is:");
            DateTime current = DateTime.Now;
            Console.WriteLine(current);

            Console.WriteLine("Input a number of hours:");
            int number = Convert.ToInt32(Console.ReadLine());
            DateTime number2 = current.AddHours(number);
            Console.WriteLine("The current time plus the hours you entered would be: " + number2);

            Console.ReadLine();
        }
    }
}
