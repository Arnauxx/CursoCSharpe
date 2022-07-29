using System;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
using Exec_17_proposto.Entities;

namespace Exec_17_proposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path:");
            string path = Console.ReadLine();

            List<Employee> employees = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                    employees.Add(new Employee(name, email, salary));
                }
            }

            Console.Write("Enter Salary: ");
            double salaryConsult = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Email of people whose salary is more than 2000.00:");


            //var emails = from e in employees
            //             where e.Salary > salaryConsult
            //             orderby e.Email
            //             select e.Email;

            var emails = employees.Where(x => x.Salary > salaryConsult).Select(x => x.Email);

            foreach(string email in emails.OrderBy(x => x))
            {
                Console.WriteLine(email);
            }

            var nameWithM = employees.Where(x => x.Name[0] == 'M').Select(x => x.Salary).Sum();



            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + nameWithM);







        }
    }
}
