using System.Globalization;
using exercicio_heranca_e_polimorfismo;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int ProductsQuantity = int.Parse(Console.ReadLine());

            for (int i = 0; i < ProductsQuantity; i++)
            {
                Console.WriteLine($"Product #{i + 1} data:");

                Console.Write($"Common, used or imported (c/u/i)? ");
                char TypeOfProduct = char.Parse(Console.ReadLine());

                Console.Write($"Name: ");
                string ProductName = Console.ReadLine();

                Console.Write($"Price: ");
                double ProductPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (TypeOfProduct == 'i')
                {
                    Console.Write($"Customs fee: ");
                    double ProductFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(ProductName, ProductPrice, ProductFee));

                }
                else if (TypeOfProduct == 'u')
                {
                    Console.Write($"Manufactured date ");
                    DateTime ProductManufacturedDate = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(ProductName, ProductPrice, ProductManufacturedDate));

                }else if (TypeOfProduct == 'c')
                {
                    products.Add(new Product(ProductName, ProductPrice));
                }
            }
            
            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }



        }
    }
}