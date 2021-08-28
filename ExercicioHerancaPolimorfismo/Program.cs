using System;
using ExercicioHerancaPolimorfismo.Entities;
using System.Collections.Generic;
using System.Globalization;


namespace ExercicioHerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int numberEmployes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberEmployes; i++)
            {
                Console.WriteLine("Employee #"+i+" data: ");
                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());


                    
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (outsourced == 'y' || outsourced == 'Y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new OutSourcedEmployee(name, hours, valuePerHours, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHours));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach(Employee emp in list)
            {
                Console.WriteLine($"{emp.Name} - {emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }

        }
    }
}
