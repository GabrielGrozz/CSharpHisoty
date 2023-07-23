using System.Globalization;
using GEnerics2.Entities;
using GEnerics2.Services;

Console.Write("Enter N: ");
int n = int.Parse(Console.ReadLine());

List<Product> list = new List<Product>();

for (int i = 0; i < n; i++)
{
    string[] data = Console.ReadLine().Split(',');

    Product product = new Product(data[0], double.Parse(data[1], CultureInfo.InvariantCulture));

    list.Add(product);
}

//instancindo a classe para podermos usar o método genérico
CalculationService calculationService = new CalculationService();

Product max = calculationService.Max(list);

Console.WriteLine("MAX:");
Console.WriteLine($"{max.Name}, {max.Value}");