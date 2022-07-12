using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class224Assignment
{
    class classOne
    {
        public void methodOne(int num1) //void method
        {
            Console.WriteLine("Your inputted value divided by 2 is " + (num1 / 2));
        }

        public static void methodTwo(out int x) //output and static
        {
            x = 25;
            x += x;
        }

        public int methodThree(int i, int j)
        {
            int addition = i + j;
            return addition;
        }
        public int methodThree(int i, int j, int k)
        {
            int addition = i + j + k;
            return addition;
        }
    }
}
