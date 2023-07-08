using ExceptionProject.ENTITIES.EXCEPTIONS;

namespace ExceptionProject.ENTITIES
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        internal void Deposit(double amount)
        {
            Balance += amount;
        }

        internal void Withdraw(double amount)
        {
            //aqui estamos verificando se será possivel fazer o saque, caso não seja possível iremos lançar uma exception no console
            if (Balance <= 0)
            {
                throw new DomainException("você precisa ter um valor na conta para que possa ser sacado");
            }
            else if (Balance < amount)
            {
                throw new DomainException("você não possui essa quantia na sua conta para sacar");
            }
            else if (amount > WithdrawLimit)
            {
                throw new DomainException("você não pode fazer um saque que ultrapasse o seu limite de saque");
            }

            Balance -= amount;
        }
    }
}
