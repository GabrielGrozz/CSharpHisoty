namespace heranca.Entities
{
    internal class Account
    {


        public int Number { get; set; }
        public string Holder { get; set; }

        public double Balance { get;  protected set; }

        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        //a palavra virtual serve para dizermos que esse metodo irá poder ser modificado nas subclasses, no caso será o mesmo método, mas de acordo com a subclasse
        //que chamar o metodo(**OLHAR AS SUBCLASSES**)
        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
