using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExecPropostoExcecoes.Entities.Exceptions;

namespace ExecPropostoExcecoes.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account()
        {

        }
        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if(amount > WithDrawLimit)
            {
                throw new DomainException("O valor de saque ultrapassou o limite de saque");
            }

            if (amount > Balance)
            {
                throw new DomainException("Saldo solicitado não disponível");
            }

            Balance -= amount;
        }



    }
}
