using System;

namespace MathChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to be multiplied by 50:");
            double result = Double.Parse(Console.ReadLine());
            Console.WriteLine(result * 50);
          
            Console.WriteLine("Enter a number to be added to 25:");
            int total = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(total + 25);

            Console.WriteLine("Enter a number to be divided by 12.5:");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine(num1 / 12.5);

            Console.WriteLine("Checks whether this number is greater than 50:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num2 > 50);

            Console.WriteLine("Input a number to be divided by 7 and this will print the remainder:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num3 % 7);
            Console.ReadLine();

        }
    }
}
