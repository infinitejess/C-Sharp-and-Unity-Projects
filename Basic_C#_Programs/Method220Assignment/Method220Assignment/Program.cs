using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method220Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoMethod add = new TwoMethod(); //instantiate the class
            
            Console.WriteLine("Enter a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());  //ask for the first number 

            Console.WriteLine("Enter a 2nd number, this is optional (hit enter either way):"); //ask for the second number but optional
            int num2; 
            if (int.TryParse(Console.ReadLine(), out num2)) //now check IF they entered a second number
            {
                Console.WriteLine(add.twoNums(num1, num2)); //if they did, print the result with num1 and num2
            }
            else
            {
                Console.WriteLine(add.twoNums(num1)); //else print the result with num1 and default of optional parameter
            }

            Console.ReadLine();
        }
    }
}
