using heranca.Entities;

Account conta1 = new Account(1050, "gabriel", 850);
Account conta2 = new SavingAccount(942, "dsm", 850, 2);

conta1.Withdraw(50);
conta2.Withdraw(50);

//qunado usamo o metodo em uma classe do tipo Account é descontado 5 de taxa, diferente da conta 2 que é uma SavingAccount que possui um override do método WithDraw.
Console.WriteLine(conta1.Balance);

Console.WriteLine(conta2.Balance);
