using System.Globalization;
using System.Net.Http.Headers;
using EmpressProject.ENTITIES;
using EmpressProject.SERVICES;

Console.WriteLine("Enter contract data");

Console.Write("Contract number: ");
int contractNumber = int.Parse(Console.ReadLine());

Console.Write("date(dd/MM/yyyy: ");
DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

Console.Write("Contract value: ");
double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Enter number of installments: ");
int contractInstallments = int.Parse(Console.ReadLine());

Contract contract = new Contract(contractNumber, contractDate, contractValue);
InstallmentsValue installment = new InstallmentsValue(contractInstallments, new PaypalTax());
installment.CalcInstallmentsValue(contract);

Console.WriteLine("");
Console.WriteLine("INSTALLMENTS:");
Console.WriteLine("");
for (int i = 0; i < contract.Installments.Count; i++)
{
    Console.Write(contract.Installments[i].DueDate.ToShortDateString() + " - ");
    Console.WriteLine(contract.Installments[i].Amount.ToString("F2", CultureInfo.InvariantCulture));
}