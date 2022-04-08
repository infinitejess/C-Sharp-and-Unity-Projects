using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> strings = new Employee<string>();
            strings.things = new List<string> { "Jess", "Jp", "Nami" };
            for (int i = 0; i < strings.things.Count; i++)
            {
                Console.WriteLine(strings.things[i]);
            }

            Employee<int> ints = new Employee<int>();
            ints.things = new List<int>() { 1, 2, 3, 4 };
            for (int i = 0; i < ints.things.Count; i++)
            {
                Console.WriteLine(ints.things[i]);
            }



            //int Id1 = 123;
            //int Id2 = 456;
            //Employee newEmp1 = new Employee();
            //newEmp1.Id = Id1;
            //Employee newEmp2 = new Employee();
            //newEmp2.Id = Id2;
            //var result = newEmp1 == newEmp2;       -->compare 2 employee objs with == overload

            //Employee newEmp = new Employee();
            //newEmp.firstName = "Sample";
            //newEmp.lastName = "Student";
            //newEmp.SayName();           --> inherited from Person class

            //IQuittable newEmp = new Employee();
            //newEmp.Quit();     -->example of interface thru emp

            Console.ReadLine();
        }
    }
}
