using Esrtoque;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Product item1 = new Product();

            //simplesmente pegamos os dados que vão ser passados e setamos no item1, que é uma instancia de Product, que por sua vez é uma classe
            Console.WriteLine("digite os dados do produto que será adicionado:");
            Console.Write("Nome do produto:");
            item1.Item = Console.ReadLine();
            Console.Write("Preço:");
            item1.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque:");
            item1.Amount = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //podemos exibir os dados dessa forma, porém ela será totalmente hardCoded, temos outra opção melhor abaixo
            Console.WriteLine($"Dados: Nome: {item1.Item}; Preço: {item1.Price.ToString("F2", CultureInfo.InvariantCulture)}; Quantidade: {item1.Amount}; Total:{item1.TotalPrice().ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine("");
            Console.Write("Ditite uma quantidade de produtos que será adicionada ao estoque:");
            //podemos reutilizar a variavel quantity, pois como ela só será utilizada uma vez, podemos reatribuir o valor dela e reutilizarmos para armazernar outro valor
            int quantity = int.Parse(Console.ReadLine());
            item1.AddItem(quantity);

            Console.WriteLine("");
            Console.WriteLine("dados atualizados!");
            //podemos mostrar os dados dessa forma também, porém ela terá que ser programada na nossa classe Product
            Console.WriteLine($"{item1}");

            Console.WriteLine("");
            Console.Write("Ditite uma quantidade de produtos que será retirada do estoque:");
            //aqui nós reutilizamos a vairavel quantitiy, para armazenar a quantidade que será removida do estoque
            quantity = int.Parse(Console.ReadLine());
            item1.RemoveItem(quantity);

            Console.WriteLine($"{item1}");



        }
    }



}