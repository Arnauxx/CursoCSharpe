using System;
using System.Globalization;
using ExecInterfaces.Entities;
using ExecInterfaces.Services;

namespace ExecInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.Write("Contract value: ");
            double totalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, totalValue);

            ContractService contractService = new ContractService(new PaypalSevice());
            contractService.ProcessContract(contract, months);

            Console.WriteLine("Installments:");


            //Foreach para retornar as informações do override no console
            foreach(Installment installments in contract.Installments)
            {
                Console.WriteLine(installments);
            }

            
        }
    }
}
