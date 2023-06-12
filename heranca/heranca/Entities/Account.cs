namespace heranca.Entities
{
    internal class Account
    {

        //essa é uma classe normal, teremos uma subclasse baseada nela, que é a BusinessAccount

        //essa é uma SUperclasse, ou seja, é uma classe base que irá servir como base para outras classes
        public int Number { get; set; }
        public string Holder { get; set; }
        // aplicamos o emcapsulamento aqui, para maior segurança utilizamos o protected, com ele os únicos que poderão editar o valor do Balance
        // são a própria classe, subclasses do assembly e subclasses fora do assembly
        public double Balance { get;  protected set; }

        public Account() { }

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
