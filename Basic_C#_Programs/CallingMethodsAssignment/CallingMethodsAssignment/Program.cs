using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to do 3 math operations on:");
            int inputNum = Convert.ToInt32(Console.ReadLine());

            CallingMethods callMeth = new CallingMethods();
            Console.WriteLine(callMeth.methodOne(inputNum));
            Console.WriteLine(callMeth.methodTwo(inputNum));
            Console.WriteLine(callMeth.methodThree(inputNum));

            Console.ReadLine();
        }
    }
}
