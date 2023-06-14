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

    }
}
