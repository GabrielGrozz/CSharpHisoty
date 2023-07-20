using GEnerics2.Entities;
using GEnerics2.Services;

Console.Write("Enter N: ");
int n = int.Parse(Console.ReadLine());

List<int> list = new List<int>();

for (int i = 0; i < n; i++)
{
    string[] data = Console.ReadLine().Split(',');

    Product product = new Product(data[0], int.Parse(data[1]));
}
