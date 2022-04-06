using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance223
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee newEmp = new Employee();
            newEmp.FirstName = "Sample";
            newEmp.LastName = "Student";
            newEmp.SayName();

            Console.ReadLine();
        }
    }
}
