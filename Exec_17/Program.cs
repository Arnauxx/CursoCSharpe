using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using Exec_17.Entites;

namespace Exec_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the file path: ");

            string path = Console.ReadLine();

            List<Product> list = new List<Product>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(",");
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);

                    list.Add(new Product(name, price));
                }
            }

            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average price: " + avg.ToString("F2", CultureInfo.InvariantCulture));

            var names = from p in list
                        where p.Price < avg
                        orderby p.Name
                        select p.Name;

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
