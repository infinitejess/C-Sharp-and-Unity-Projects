using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    abstract public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        abstract public void SayName();

    }
}
