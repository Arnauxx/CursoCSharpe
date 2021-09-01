using System;
using System.Globalization;
using ExecPropostoExcecoes.Entities;
using ExecPropostoExcecoes.Entities.Exceptions;

namespace ExecPropostoExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int numberAccount = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double inicialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                Account account = new Account(numberAccount, holder, inicialBalance, withDrawLimit);

                Console.Write("Enter amount for withdraw: ");
                double withDraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.WithDraw(withDraw);

                Console.WriteLine("New Balance: " + account.Balance);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro no saque: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro inesperado: " + e.Message);
            }



        }
    }
}
