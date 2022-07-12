using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 4;
            switch(day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                default:
                    Console.WriteLine("Weekend");
                    break;
            }

            //int num1 = 15;
            //int num2 = 14;

            //string result = num1 > num2 ? "num1 is greater than num2" : "num1 is not greater than num2";
            //Console.WriteLine(result);
            
            
            
            //Console.WriteLine("Are we the same height?");
            //int height = Convert.ToInt32(Console.ReadLine());

            //if (height <= 69)
            //{
            //    Console.WriteLine("No, we are not");
            //}

         
            //if (height > 69)
            //{
            //    Console.WriteLine("Yes, you are!");
            //}
            //else if (height < 69)
            //{
            //    Console.WriteLine("No, you arent!");
            //}
            //else if (height == 69)
            //{
            //    Console.WriteLine("We are the same height!");
            //}
            //else
            //{
            //    Console.WriteLine("You didnt reply.");
            //}
            Console.ReadLine();
        }
    }
}
