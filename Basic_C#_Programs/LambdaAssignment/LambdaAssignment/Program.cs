using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee("James", "Innocent", 1));
            empList.Add(new Employee("Joe", "Smith", 2));
            empList.Add(new Employee("Jp", "Guilty", 3));
            empList.Add(new Employee("Jess", "Fellows", 4));
            empList.Add(new Employee("Zoro", "Warren", 5));
            empList.Add(new Employee("Luffy", "Pirate", 6));
            empList.Add(new Employee("Nami", "Dog", 7));
            empList.Add(new Employee("Jimbei", "Kelly", 8));
            empList.Add(new Employee("Sanji", "Pizzi", 9));
            empList.Add(new Employee("Joe", "Bob", 10));

            List<Employee> joeList1 = new List<Employee>();
            foreach (var employee in empList)

            {
                if (employee.FirstName == "Joe")
                {
                    joeList1.Add(employee);
                }
            }
            foreach(Employee emp in joeList1)
            {
                Console.WriteLine(emp.FirstName);
            }


            List<Employee> joeList2 = empList.Where(y => y.FirstName == "Joe").ToList();
            foreach (Employee emp in joeList2)
            {
                Console.WriteLine(emp.FirstName);
            }

            List<Employee> joeList3 = empList.Where(x => x.ID >= 5).ToList();
            foreach (Employee emp in joeList3)
            {
                Console.WriteLine(emp.ID);
            }

            Console.ReadLine();
        }
    }
}
