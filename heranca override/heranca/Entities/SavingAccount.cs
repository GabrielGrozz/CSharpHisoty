namespace heranca.Entities
{
    internal class SavingAccount : Account
    {
        public double InterestRate;
        public SavingAccount() { }
        public SavingAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance ()
        {
            Balance += Balance * InterestRate;
        }

        //SOBREPOSIÇÃO  
        // uma sobreposição seria nós utilizarmos um método de uma superclasse em uma subclasse
        //a
        //
        //quando for necessário sobrescrever um método precisamo utilizar a palavra override nele

        //o método WithDraw é um método do Account, mas aqui estas modificando ele
        public override void Withdraw(double amount)
        {
            Balance -= amount;
        }

    }
}
