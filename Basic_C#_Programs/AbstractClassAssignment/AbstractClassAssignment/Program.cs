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
            IQuittable newEmp = new Employee();
            //newEmp.firstName = "Sample";
            //newEmp.lastName = "Student";
            //newEmp.SayName();

            newEmp.Quit(); 

            Console.ReadLine();
        }
    }
}
