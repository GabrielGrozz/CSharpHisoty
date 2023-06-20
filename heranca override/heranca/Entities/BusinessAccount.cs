namespace heranca.Entities
{

    internal class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }
        public BusinessAccount() { }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }


        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {

                Balance += amount;
            }
        }

        public override void Withdraw(double amount)
        {
            // a palavra base remete a nossa superclasse, nesse caso o método esta sendo chamado na super classe e iremos fazer
            // o nosso tratamento após a execução so método na superclasse
            base.Withdraw(amount);
            Balance -= 2;
        }


    }
}
