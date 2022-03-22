using System;
using System.Collections.Generic;
using RestricoesGenerics.Services;
using RestricoesGenerics.Entities;
using System.Globalization;

namespace RestricoesGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Product(name, price));
            }

            CalculationServices calculationServices = new CalculationServices();

            Product max = calculationServices.Max(list);

            Console.WriteLine("Max:");
            Console.WriteLine(max);

        }
    }
}
