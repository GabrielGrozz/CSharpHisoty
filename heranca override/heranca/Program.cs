using heranca.Entities;

//oque estamos fazendo abaixo é u exemplo de polimorfismo, o compilador não irá saber as conta1,2,3 são de tipos diferentes, só irá saber que são instancias
//do tipo Account que possuem o método Withdraw, essa facilidade de podermos instanciarmos uma subclasse em uma variavel do tipo da superclasse é um tipo de polimorfismo.
Account conta1 = new Account(1050, "gabriel", 850);
Account conta2 = new SavingAccount(942, "dsm", 850, 2);
Account conta3 = new BusinessAccount(6481, "leoneip", 850, 60);

conta1.Withdraw(50);
conta2.Withdraw(50);
conta3.Withdraw(50);

//SOBREPOSIÇÃO  
// uma sobreposição seria nós utilizarmos um método de uma superclasse em uma subclasse
//qunado usamo o metodo em uma classe do tipo Account é descontado 5 de taxa, diferente da conta2 que é uma SavingAccount que possui um override do método WithDraw.
Console.WriteLine(conta1.Balance);

Console.WriteLine(conta2.Balance);

//utilizando outro modo utiizando a palavra base
Console.WriteLine(conta3.Balance);
