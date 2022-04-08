using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        public enum daysOfWeek
        { 
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What day of the week is it?");
            string dayInput = Console.ReadLine();
            daysOfWeek day;

            try
            {
                day = (daysOfWeek)Enum.Parse(typeof(daysOfWeek), dayInput);
                Console.WriteLine("Good job!");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week. (Hint: Capitalize the first letter.)");
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
