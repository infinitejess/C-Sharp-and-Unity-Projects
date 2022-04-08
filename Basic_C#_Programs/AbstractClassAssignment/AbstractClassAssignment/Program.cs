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
            int Id1 = 123;
            int Id2 = 456;

            Employee newEmp1 = new Employee();
            newEmp1.Id = Id1;

            Employee newEmp2 = new Employee();
            newEmp2.Id = Id2;

            var result = newEmp1 == newEmp2;

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
