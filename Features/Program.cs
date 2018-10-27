using System.Collections.Generic;
using System;
using System.Linq;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<int, int> f = (x) => x * x;

            Func<int, int, int> add = (x,y) => x + y;



            Action<int> result = x => Console.WriteLine(x);

            result(f(add(3, 5)));
           

            var developers = new Employee[]
            {
                new Employee{Id = 1, Name = "Sean"},
                new Employee{Id = 2, Name = "Cody"}
            };

            var sales = new List<Employee>()
            {
                new Employee{Id=3, Name="Connor"}
            };

            //Console.WriteLine(developers.Count());




            //foreach (var employee in developers.Where(
            //            e => e.Name.StartsWith("C")))
            //{
            //     Console.WriteLine($"{employee.Name}");
            //}

            var devEmployees = developers.Where(e => e.Name.Length == 4)
                                         .OrderBy(e => e.Name);

            var devEmployeesQuery = from developer in developers
                                    where developer.Name.Length == 4
                                    orderby developer.Name
                                    select developer;

            foreach (var employee in devEmployees)                            
            {
                Console.WriteLine(employee.Name);
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
