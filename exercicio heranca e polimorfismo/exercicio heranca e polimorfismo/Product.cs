using System.Globalization;
namespace exercicio_heranca_e_polimorfismo;

internal class Product
{
    internal string Name { get; set; }
    internal double Price { get; set; }

    internal Product() { }
    internal Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    internal virtual string PriceTag()
    {
        return $"{Name} ${Price.ToString("F2", CultureInfo.InvariantCulture)}";
    }
}
