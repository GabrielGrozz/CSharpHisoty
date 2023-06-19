//herança é basicamente a capacidade de uma classe passar seus atributos para uma subclasse dela.

using heranca.Entities;

BusinessAccount contaBancaria = new BusinessAccount(150, "gabriel", 1500, 500);

Console.WriteLine(contaBancaria.Balance);

//temos o upcasting eo downcastig, que basicamente é converter uma classe em outra, ou seja, uma subclasse para uma superclasse ou ao contrario
// upcasting = subclasse para superclasse
//downcasting = superclasse para subclasse.

BusinessAccount account1 = new BusinessAccount();


//UPCASTING
//aqui estamos transformando um bussinesaccount em um account
Account conta1 = account1;
//podemos instanciar direto também

// o compilador não irá saber que os tipos armazenados em Account são diferentes, o compilador irá considerar apenas o tipo que foi passado
//na variavel que está armazenando, no caso a conta2 e conta3 não terão os métodos exclusivos delas, pq o compilador as considera do tipo Account
Account conta2 = new BusinessAccount();
Account conta3 = new SavingAccount();

//DOWNCASTING
//quando formos fazer um downcasting teremos que fazer um casting

//para que possamos dai utilizar os métodos exclusivos das classes, podemos fazer um downcasting pegando as variaveis que estamos
//utilizando para armazenar as outras
//isso é aceitavel pelo compilador

//podemos fazer o casting de duas formas, uma ja convencional e outra usando o as
//BusinessAccount conta4 = (BusinessAccount)conta2;
BusinessAccount account2 = conta2 as BusinessAccount;

//não podemos pegar um tipo que esta armazenado e transformalo em outro tipo
//isso irá gerar um erro
//BusinessAccount conta5 = (SavingAccount)conta3;

//podemos testar se um tipo armazenado em account é do tipo que queremos usando o operador 'is"

//basicamente irá verificar se é do tipo passado
if(conta2 is BusinessAccount)
{
    Console.WriteLine("bussines");
}
else
{
    Console.WriteLine("not bussines");
}




