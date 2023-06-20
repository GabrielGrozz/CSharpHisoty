namespace heranca.Entities
{
    //PODEMOS UTILIZAR A PALAVRA SEALED NA CLASSE TAMBÉM, COM ISSO IREMOS IMPEDIR QUE ELA POSSA SER UMA SUPERCLASSE, ASSIM PODENDO MANTER A SEGURANÇA DE ALGUMAS SITUAÇÕES
    internal sealed class SavingAccount : Account
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

        // a palabvra sealed remete a um método selado, ela só pode ser usada em métodos sobrepostos(override), fazendo com que eles não possam mais ser sobrepostos
        public sealed override void Withdraw(double amount)
        {
            Balance -= amount;
        }

    }
}
