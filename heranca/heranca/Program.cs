//herança é basicamente a capacidade de uma classe passar seus atributos para uma subclasse dela.

using heranca.Entities;

BusinessAccount contaBancaria = new BusinessAccount(150, "gabriel", 1500, 500);

Console.WriteLine(contaBancaria.Balance);