using ExceptionProject.ENTITIES;
using ExceptionProject.ENTITIES.EXCEPTIONS;

try
{
    Console.WriteLine("Enter account dataa:");

    Console.Write("Number: ");
    int accountNumber = int.Parse(Console.ReadLine());

    Console.Write("Holder: ");
    string accountHolder = Console.ReadLine();

    Console.Write("Initial balance: ");
    double accountInitialBalance = double.Parse(Console.ReadLine());

    Console.Write("Withdraw limit: ");
    double accountWithdrawLimit = double.Parse(Console.ReadLine());

    Account account = new Account(accountNumber, accountHolder, accountInitialBalance, accountWithdrawLimit);
    Console.WriteLine();

    Console.Write("Enter amount for withdraw: ");
    double WithdrawAmount = double.Parse(Console.ReadLine());
    account.Withdraw(WithdrawAmount);

    Console.WriteLine($"New balance: {account.Balance}");
}
catch (DomainException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}