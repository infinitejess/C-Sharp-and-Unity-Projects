using System;
using System.Collections.Generic;


    class Program
    {
        static void Main()
        {
        //String array
        string[] stringArray = { "dog", "cat", "hamster", "zerba" };
        Console.WriteLine("Please select an index from 0-3:");
        int value = Convert.ToInt32(Console.ReadLine());
        if (value > 3)
        {
            Console.WriteLine("The number you entered was not between 0-3.");
        }
        else
        {
            Console.WriteLine(stringArray[value]);
        }


        //Integer array
        int[] intArray = { 12, 14, 16, 18 };
        Console.WriteLine("Please select an index from 0-3:");
        int value1 = Convert.ToInt32(Console.ReadLine());
        if (value1 > 3)
        {
            Console.WriteLine("The number you entered was not between 0-3.");
        }
        else
        { 
            Console.WriteLine(intArray[value1]);
        }

        List<string> stringList = new List<string>();
        stringList.Add("Jess");
        stringList.Add("Jp");
        stringList.Add("Nami");
        stringList.Add("Sanji");
        Console.WriteLine("Please select an index from 0-3:");
        int value2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(stringList[value2]);

        Console.ReadLine();
        }
    }

