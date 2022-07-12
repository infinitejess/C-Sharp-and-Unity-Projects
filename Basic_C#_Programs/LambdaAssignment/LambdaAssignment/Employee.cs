using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public int ID;

        public Employee (string firstname, string lastname, int id)
        {
            FirstName = firstname;
            LastName = lastname;
            ID = id;
        }

    }
}
