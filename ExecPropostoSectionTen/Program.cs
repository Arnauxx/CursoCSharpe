using System;
using System.Globalization;
using ExecPropostoSectionTen.Entities;
using System.Collections.Generic;

namespace ExecPropostoSectionTen
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int numberProducts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberProducts; i++)
            {
                Console.WriteLine("Product #" + i + " data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char Common = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                switch (Common)
                {
                    case 'c':

                        list.Add(new Product(name, price));

                        break;

                    case 'i':

                        Console.Write("Customs fee: ");
                        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        list.Add(new ImportedProduct(name, price, customsFee));

                        break;

                    case 'u':

                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        list.Add(new UsedProduct(name, price, date));

                        break;

                    default:
                        Console.WriteLine("Digito invalido!");

                        break;
                }

            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");

            foreach (Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }



        }
    }
}
