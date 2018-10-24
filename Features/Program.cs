using System.Collections.Generic;
using System;

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

            foreach (var developer in developers)
            {
                 Console.WriteLine($"{developer.Name}");
            }

            foreach (var employee in sales)
            {
                 Console.WriteLine($"{employee.Name}");
            }
             


        }
    }
}
