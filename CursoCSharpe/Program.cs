using System;
using CursoCSharpe.Entities;
using CursoCSharpe.Entities.Enums;
using System.Globalization;

namespace CursoCSharpe
{
    class Program
    {
        static void Main(string[] args)
        {

            //Mains variables
            /*
            Order order = new Order 
            {
                
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment

            };
            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            //Impressions
            Console.WriteLine(order);
            Console.WriteLine(os);
            Console.WriteLine(txt);
            */

            Console.Write("Digite o nome do Departamento: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Digite as informações do trabalho: ");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Nivel (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Salário base: ");
            double baseSalary = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);
            
            Console.Write("Com quantos contratos você trabalhou? ");
            int totalContracts = int.Parse(Console.ReadLine());

            if(totalContracts != 0)
            {
                for(int i = 1; i <= totalContracts; i++)
                {
                    Console.WriteLine("Digite a data do contrato #" + i);
                    Console.Write("Data (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    Console.Write("Valor por hora: ");
                    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Quantidade de horas: ");
                    int hours = int.Parse(Console.ReadLine());
                    HourContract contract = new HourContract(date, valuePerHour, hours);
                    worker.AddContract(contract);

                }

                Console.Write("Entre com o mes e ano para calcular (MM/YYYY)");
                string monthAndYear = Console.ReadLine();
                int month = int.Parse(monthAndYear.Substring(0, 2));
                int year = int.Parse(monthAndYear.Substring(3));

                Console.WriteLine("Nome: " + worker.Name);
                Console.WriteLine("Departamento: " + worker.Department.Name);
                Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)} ");


            }

            



        }
    }
}
