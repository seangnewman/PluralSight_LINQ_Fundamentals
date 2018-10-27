using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = ProcessFile("fuel.csv");


            var result1 = cars.SelectMany(c => c.Name)
                .OrderBy(c => c);
 
                 
                foreach (var character in result1)
                {
                    Console.WriteLine(character);
                }
           



            //var effQuery = cars.Where(c => c.Manufacturer == "BMW" && c.Year == 2016)
            //                   .OrderByDescending(c => c.Combinded)
            //                   .ThenBy(c => c.Name)
            //                   .Select(c => new { c.Manufacturer, c.Name, c.Combinded });
                                
             

            //var topEffCar = cars.OrderByDescending(c => c.Combinded)
            //                  .ThenBy(c => c.Name)
            //                  .First(c => c.Manufacturer == "BMW" && c.Year == 2016);

           

            //Console.WriteLine($"The most efficient car is {topEffCar.Name}");

            ////var result = cars.Any(c => c.Manufacturer == "Ford");
            ////Console.WriteLine("Are there any Ford's? {0}", result);

            ////var result = cars.All(c => c.Manufacturer == "Ford");
            ////Console.WriteLine("Are all the cars manufactured by Ford? {0}", result);

            //var result = cars.Select(c => c.Manufacturer).Contains("Ford");
            //Console.WriteLine("Are any cars manufactured by Ford? {0}", result);

            //foreach (var car in effQuery.Take(10))
            //{
            //    Console.WriteLine($"{car.Name} : {car.Combinded}");
            //}

        }

        private static List<Car> ProcessFile(string path)
        {
            var query = File.ReadAllLines(path)
                        .Skip(1)                            // Skip header 
                        .Where(line => line.Length > 1)     // Only lines with data (avoids last line)
                        .ToCar();
            return query.ToList();      
                      
        }

        private static List<Car> ProcessFileQuery(string path)
        {

            var query = from line in File.ReadAllLines(path)
                        .Skip(1)
                        where line.Length > 1
                        select Car.ParseFromCsv(line);
            return query.ToList();
        }







    }

  
}
