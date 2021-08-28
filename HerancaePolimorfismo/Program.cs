using HerancaePolimorfismo.Entities;
using System.Collections.Generic;
using System;
using System.Globalization;

namespace HerancaePolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.00);


            //Upcasting

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.00);
            Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

            //Downcasting

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.00);

            //BusinessAccount acc5 = (BusinessAccount)acc3;

            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.00);
                Console.WriteLine("Loan!");
            }

            if(acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
            
            */


            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.00, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.00, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.00, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.00, 500.00));

            double sum = 0.0;
            foreach(Account acc in list)
            {
                sum += acc.Balance;

            }

            Console.WriteLine("Total accounts: " + sum.ToString("F2", CultureInfo.InvariantCulture));


            foreach(Account acc in list)
            {
                acc.Withdraw(10.0);
            }

            foreach(Account acc in list)
            {
                Console.WriteLine(
                    "Update total balance accounts" + 
                    acc.Number +
                    ": " +
                    acc.Balance.ToString("F2", CultureInfo.InvariantCulture)
                    );
            }

        }
    }
}
