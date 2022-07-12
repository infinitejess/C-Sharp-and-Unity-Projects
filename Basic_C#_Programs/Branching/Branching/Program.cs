using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite number?");
            int favnum = Convert.ToInt32(Console.ReadLine());

            string result = favnum == 12 ? "You have an awesome fave number." : "You do not have an awesome fave number.";
            Console.WriteLine(result);
            Console.ReadLine();
            //int roomTemperature = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temp where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temp.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temp.");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("It is cooler than room temp.");
            //}
            //else
            //{
            //    Console.WriteLine("Uhhhh something went wrong.");
            //}

            //int currentTemperature = 80;
            //int roomTemperature = 70;

            //string comparisonResult = currentTemperature == roomTemperature ? "It is room temp" : "It is not room temp.";
            //Console.WriteLine(comparisonResult);
            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temprature.");
            //}
            //else if (roomTemperature > currentTemperature)
            //    {
            //    Console.WriteLine("Room temperature is warmer than current temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("It is not exactly room tempearture.");
            //}
            //Console.ReadLine();
        }
    }
}
