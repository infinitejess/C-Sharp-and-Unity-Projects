using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        try
        {
            //List of integers
            List<int> numbers = new List<int>() { 10, 20, 30, 40, 50 };

            //Ask for user input
            Console.WriteLine("Enter a number to divide all numbers in the list by:");
            int numInput = Convert.ToInt32(Console.ReadLine());

            //Loop that divides each value by input number and displays result
            for (int i = 0; i < numbers.Count; i++)
            {
                int numResult = numbers[i] / numInput;
                Console.WriteLine(numResult);
            }
        }
        //catch for wrong format of inputted value
        catch (FormatException ex)
        {
            Console.WriteLine("Please enter a whole number.");
        }
        //catch for dividing by zero
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("You cannot divide by zero.");
        }

        //after try/catch message
        finally 
        {
            Console.WriteLine("You are out of the try/catch block!");        
        }


        Console.ReadLine();
    }
}

