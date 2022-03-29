using System;

namespace MathAndCompAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");

            Console.WriteLine("Enter Hourly Rate:");
            int p1Hourly = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Enter hours worked per week:");
            int p1WeekHours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2");

            Console.WriteLine("Enter Hourly Rate:");
            int p2Hourly = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter hours worked per week:");
            int p2WeekHours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Annual salary of Person 1: " + (p1Hourly * p1WeekHours) * 52);
            Console.WriteLine("Annual salary of Person 2: " + (p2Hourly * p2WeekHours) * 52);

            int person1 = ((p1Hourly * p1WeekHours) * 52);
            int person2 = ((p2Hourly * p2WeekHours) * 52);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(person1 > person2);
            Console.ReadLine();
        }
    }
    }

