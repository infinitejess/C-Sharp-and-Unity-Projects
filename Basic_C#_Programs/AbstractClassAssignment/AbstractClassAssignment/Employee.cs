using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Employee /*: Person, IQuittable*/
    {
        //public override void SayName()
        //{
        //    Console.WriteLine("Name: " + firstName + " " + lastName);
        //}

        //public void Quit()
        //{
        //    Console.WriteLine("I quit! BUH-bye.");
        //}

        public int Id { get; set; }

        public static bool operator== (Employee newEmp1, Employee newEmp2)
        {
           if (newEmp1.Id == newEmp2.Id)
            {
                Console.WriteLine("The Ids are equal");
                return true;
            }
           else
            {
                Console.WriteLine("The Ids are not equal");
                return false;
            }
        }

        public static bool operator !=(Employee newEmp1, Employee newEmp2)
        {
            if (newEmp1.Id != newEmp2.Id)
            {
                Console.WriteLine("The Ids are not equal");
                return false;
            }
            else
            {
                Console.WriteLine("The Ids are equal");
                return true;
            }
        }
    }
    }

