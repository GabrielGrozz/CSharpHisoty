using System.Globalization;
using FixacaoPrivate;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //podemos iniciar aqui ja a nossa classe
            Account partner;

            Console.Write("Entre o número da conta: ");
            int accountId = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Entre o titular da conta: ");
            string owner = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Deseja fazer um depósito inicial( s / n )?");
            char initialDeposit = char.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (initialDeposit == 's' || initialDeposit == 'S')
            {
                Console.Write("Digite o valor do depósito: ");
                double deposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                partner = new Account(accountId, owner, deposit);

            }
            else
            {
                partner = new Account(accountId, owner);
            }


            Console.WriteLine($"Dados da conta: Número da conta:{partner.Id}; Titular:{partner._owner}; Valor para disponível para saque: {partner.Value:F2}");
            Console.WriteLine("");
            Console.Write("Digite um valor para depósito: ");
            double money = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            partner.Deposito(money);

            Console.WriteLine("");
            Console.Write("Dados atualizados!!!");
            Console.WriteLine("");
            Console.Write($"Dados da conta: Número da conta:{partner.Id}; Titular:{partner._owner}; Valor para disponível para saque: {partner.Value:F2}");
            Console.WriteLine("");

            Console.Write("Digite um valor para saque: ");
            money = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            partner.SetWithdrawal(money);
            Console.WriteLine("");

            Console.Write("Dados atualizados!!!");
            Console.WriteLine("");
            Console.Write($"Dados da conta: Número da conta:{partner.Id}; Titular:{partner._owner}; Valor para disponível para saque: {partner.Value:F2}");
            Console.WriteLine("");
            Console.WriteLine("");


        }
    }
}

