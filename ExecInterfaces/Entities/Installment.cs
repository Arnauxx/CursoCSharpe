using System;
using System.Globalization;

namespace ExecInterfaces.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        //CONSTRUTOR
        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        //INICIO RETORNO CONSOLE
        public override string ToString()
        {
            return
                DueDate.ToString("dd/MM/yyyy")
                +
                " - "
                +
                Amount.ToString("F2", CultureInfo.InvariantCulture);

        }
        //FIM RETORNO CONSOLE





    }
}
