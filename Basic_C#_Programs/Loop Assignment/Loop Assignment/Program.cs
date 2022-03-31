using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        //One dimensial array of strings
        string[] names = { "Jess", "Jp", "Nami", "Sanji" };

        //Ask user for text input
        Console.WriteLine("Please enter something to be added to the end of a name:");
        string namesPlus = Console.ReadLine();

        //Loop that iterates thru each string and adds user's text to end
        for (int i = 0; i < names.Length; i++)
        {
            names[i] += namesPlus;
        }

        //Loop that prints off each string on a separate line
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        //infinite loop (while) -> fixed loop (added break)
        while (true)
        {
            Console.WriteLine("To infinity and beyond!");
            break;
        }

        //loop iterating with <
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i < 6)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        //loop iterating with <=
        int[] numbers2 = { 0, 1, 2, 3, 9, 10, 11};

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i <= 3)
            {
                Console.WriteLine(numbers2[i]);
            }
        }

        //list of strings that are all unique
        List<string> lastNames = new List<string>() { "Fellows", "Innocent", "Parhiala", "Pizzi", "Johnson" };
        
        //ask for user input
        Console.WriteLine("Guess the last name of the murderer:");
        string guessName = Console.ReadLine();

        //check and display index of correct guess or not
        int matchIndex = -1;
             for (int i = 0; i < lastNames.Count; i++)
                { 
                    if (guessName == lastNames[i])
                     {
                    matchIndex = i;
                    break;
                     }
                }
             if (matchIndex >= 0)
                {
                    Console.WriteLine(matchIndex);
                }
            else
                {
                    Console.WriteLine("That name is not in the list.");
                }

        //List of strings with two identical strings and ask for user input
        List<string> animals = new List<string>() { "cat", "dog", "bird", "snake", "cat" };
        Console.WriteLine("Find the animal listed twice: cat, dog, bird, snake:");
        string pickAnimal = Console.ReadLine();

        //loop to find the matching value and print index 
        bool matchAnimal = false;
        for(int i = 0; i < animals.Count; i++)
        {
            if (animals[i] == pickAnimal)
            {
                matchAnimal = true;
                Console.WriteLine("At Index: "+ i);
            }
        }
        if (matchAnimal == false)
        {
            Console.WriteLine("That animal is not in the list.");
        }

        //string list with 2 identical values
        List<string> cities = new List<string>() { "New York", "San Diego", "Los Angeles", "New York" };
        List<string> unique = new List<string>();
        List<string> duplicates = new List<string>();

        //foreach evalutes each element, display message showing string and if its a repeat
      
        foreach (string city in cities)
        {
            if (!unique.Contains(city))
            {
                unique.Add(city);
                continue;
            }
            else
            {
                duplicates.Add(city);
            }

             foreach (string city1 in unique)
                {
                    Console.WriteLine(city1 + " is unique");
                }
             foreach (string city2 in duplicates)
                {
                    Console.WriteLine(city2 + " is a duplicate");
                }

        }


        Console.ReadLine();
            }
        }

