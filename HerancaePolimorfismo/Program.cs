using System;
using HerancaePolimorfismo.Entities;

namespace HerancaePolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.00, 500.00);

            Console.WriteLine(account.Balance);

            //account.Balance += 200.00; //Não é possível alterar por conta do protected



        }
    }
}
