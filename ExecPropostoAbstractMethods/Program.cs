using System;
using ExecPropostoAbstractMethods.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace ExecPropostoAbstractMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();

            Console.Write("Enter the number of tax payers: ");
            int payers = int.Parse(Console.ReadLine());

            for(int i = 1; i <= payers; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c): ");
                char ic = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ic == 'i')
                {
                    Console.Write("Health expeditures: ");
                    double healthExp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new FisicPerson(name, income, healthExp));
                }
                else
                {
                    Console.Write("Number of Employees: ");
                    int employee = int.Parse(Console.ReadLine());
                    list.Add(new JuridicPerson(name, income, employee));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double sum = 0.0;
            foreach(Person person in list)
            {
                double tax = person.Tax();
                Console.WriteLine($"{person.Name}: $ {person.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
                sum += tax;
            }
            Console.WriteLine();
            Console.WriteLine($"Total taxes: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
