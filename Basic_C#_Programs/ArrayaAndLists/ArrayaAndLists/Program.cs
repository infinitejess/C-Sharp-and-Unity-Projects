using System;
using System.Collections.Generic; //Namespace that we are going to use for creating lists

    class Program
    {
        static void Main()
        {//Manual way to set each array value
        //        int[] numArray = new int[5];
        //        numArray[0] = 5;
        //        numArray[1] = 2;
        //        numArray[2] = 10;
        //        numArray[3] = 200;
        //        numArray[4] = 5000;

        ////Faster way but once you put those numbers in, it'set at that length
        //        int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

        ////Another way to instantiate an array - easiest
        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        //numArray2[5] = 650; //You can target exact elemtns of the array and can change them but you are limited to that length

        //        Console.WriteLine(numArray2[5]);
        //        Console.ReadLine();

        List<string> intList = new List<string>();
        intList.Add("Hello");
        intList.Add("Jesse");
        intList.Remove("Jesse");

        Console.WriteLine(intList[0]);
        Console.ReadLine();

        byte[] byteArray = 
    }
    }

