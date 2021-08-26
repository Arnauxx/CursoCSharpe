namespace HerancaePolimorfismo.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }//Só pode ser alterado pela classe
        public double Balance { get; protected set; } //Pode ser alterado somente pela classe ou subclasses

        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }




    }
}
