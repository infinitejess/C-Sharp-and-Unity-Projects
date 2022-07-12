using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            decimal num2 = 12.5m;
            string num3 = "3";

            OpsMethods methOne = new OpsMethods();
            Console.WriteLine("Result one: " + methOne.methodOne(num1));

            OpsMethods methTwo = new OpsMethods();
            Console.WriteLine("Result two: " + methTwo.methodOne(num2));

            OpsMethods methThree = new OpsMethods();
            Console.WriteLine("Result three: " + methThree.methodOne(num3));

            Console.ReadLine();
        }
    }
}
