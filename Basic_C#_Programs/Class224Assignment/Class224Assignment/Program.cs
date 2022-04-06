using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class224Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            classOne result = new classOne();                     //instantiate class
            Console.WriteLine("Please enter a number:");          //request value
            int num1 = Convert.ToInt32(Console.ReadLine());       //print value
            result.methodOne(num1);                              //call method on inputted value

            int x;                    //declare varibale (no assigned value)
            classOne.methodTwo(out x);        //pass variable to method (static = dont have to instantiate class)
            Console.WriteLine("Out parm method equals: " + x); //print result

            int sum1 = result.methodThree(10, 20);
            Console.WriteLine("2 varaible addition equals: "+ (sum1));   //methodthree with 2 variables

            int sum2 = result.methodThree(10, 20, 15);
            Console.WriteLine("2 varaible addition equals: " + (sum2));    ///methodthree with 3 variables

            classTwo.showText(); //static class 

            Console.ReadLine();
        }
    }
}
