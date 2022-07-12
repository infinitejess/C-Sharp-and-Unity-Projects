using System;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? Reply with True/False");
            bool dui = bool.Parse(Console.ReadLine());
           
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?");
            Console.WriteLine(age > 15 && dui != true && tickets <= 3);

            Console.ReadLine();

        }
    }
}
