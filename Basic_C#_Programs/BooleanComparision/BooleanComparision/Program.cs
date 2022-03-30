using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanComparision
{
    class Program
    {
        static void Main(string[] args)
        {//While loop
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i); i++;
            }

            int j = 5;
           //do while loop
            do
            {
                Console.WriteLine("j = {0}", j);
                j++;
            } while (j < 20);
            
            
            Console.ReadLine();
            
        }
    }
}
