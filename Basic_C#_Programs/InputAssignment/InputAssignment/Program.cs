using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        { 
           
            Console.WriteLine("Please input a number.");
            int number = Convert.ToInt32(Console.ReadLine());
            string newNum = number.ToString();
            File.WriteAllText(@"C:\Users\jessi\OneDrive\Documents\log.txt", newNum);
            string newNumm = File.ReadAllText(@"C:\Users\jessi\OneDrive\Documents\log.txt");
            Console.WriteLine("Here is your file being read back: " + newNumm);
            Console.ReadLine();
        }
    }
}
