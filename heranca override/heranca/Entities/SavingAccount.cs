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

        //aqui estamos fazendo um override no método do Account, isso seria como sobreescrever o método
        public override void Withdraw(double amount)
        {
            Balance -= amount;
        }

    }
}
