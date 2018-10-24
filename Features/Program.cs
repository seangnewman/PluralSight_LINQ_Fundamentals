using System.Collections.Generic;
using System;
using System.Linq;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee{Id = 1, Name = "Sean"},
                new Employee{Id = 2, Name = "Cody"}
            };

            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee{Id=3, Name="Connor"}
            };

            //Console.WriteLine(developers.Count());

            


            foreach (var employee in developers.Where(
                        e => e.Name.StartsWith("C")))
            {
                 Console.WriteLine($"{employee.Name}");
            }



            //foreach (var employee in sales)
            //{
            //     Console.WriteLine($"{employee.Name}");
            //}
             


        }

        private static bool NameStartsWithC(Employee employee)
        {
            return employee.Name.StartsWith("C");
        }
    }
}
