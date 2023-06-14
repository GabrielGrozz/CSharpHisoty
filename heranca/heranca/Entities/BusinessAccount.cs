namespace heranca.Entities
{
    //essa é uma subclasse, ela irá usar a Superclasse como base de sua herança

    //como se trata de uma classe que irá se basear na classe Account, passamos a classe Account após os : para informarmos que iremos
    // nos basear nela, ou seja, usaremos o Account como herança

    // o dois pontos(:) significa extend, ou seja, ele esta extendendo algo
    internal class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }
        public BusinessAccount() { }
        //para não precisarmos criar um construtor com todas as referencias, podemos usar o : base
        // O : base serve para usarmos o construtor do Accounto como base
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        //se a quantidade for menor ou igual ao limite...
        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                // só está visivel por causa do protected
                Balance += amount;
            }
        }


    }
}
