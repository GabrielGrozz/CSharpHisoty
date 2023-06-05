using construtores;
using System;
using System.Globalization;
using System.Runtime;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //um construtor é uma operação que executa no momenta da instanciação de um objeto
            //o new seria uma forma de instanciarmos um construtor, podendo ser ele vazio ou com os dados
            //Product item1 = new Product();

            Console.WriteLine("digite os dados do produto que será adicionado:");
            Console.Write("Nome do produto:");
            string item = Console.ReadLine();
            Console.Write("Preço:");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            /*
            Console.Write("Quantidade em estoque:");
            int amount = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            */

            //aqui somos obrigados a passar os valores para o construtor
            Product item1 = new Product(item, price);

            Console.WriteLine($"Dados: Nome: {item1.Item}; Preço: {item1.Price.ToString("F2", CultureInfo.InvariantCulture)}; Quantidade: {item1.Amount}; Total:{item1.TotalPrice().ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine("");
            Console.Write("Ditite uma quantidade de produtos que será adicionada ao estoque:");
            int quantity = int.Parse(Console.ReadLine());
            item1.AddItem(quantity);

            Console.WriteLine("");
            Console.WriteLine("dados atualizados!");
            Console.WriteLine($"{item1}");

            Console.WriteLine("");
            Console.Write("Ditite uma quantidade de produtos que será retirada do estoque:");
            quantity = int.Parse(Console.ReadLine());
            item1.RemoveItem(quantity);

            Console.WriteLine("");
            Console.WriteLine("dados atualizados!");
            Console.WriteLine($"{item1}");


        }
    }

}