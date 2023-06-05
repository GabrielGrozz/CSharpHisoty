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

            // *********************************************************************************************************************************************************************
            // *********************************************************************************************************************************************************************
            // *********************************************************************************************************************************************************************
            // *************************************************************  THIS   ***********************************************************************************************

            // a palavra this é utilizada para referenciar o próprio elemento, como em parametros










            // *********************************************************************************************************************************************************************
            // *********************************************************************************************************************************************************************
            // *********************************************************************************************************************************************************************
            // *********************************************************************************************************************************************************************
            Console.WriteLine("digite os dados do produto que será adicionado:");
            Console.Write("Nome do produto:");
            string item = Console.ReadLine();
            Console.Write("Preço:");

            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Product item1 = new Product(item, price, 0);

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


            //também podemos instanciar uma classe desse jeito, onde escrevemos diretamente oque é oque na classe
            //porém para que possamos utilziar essa forma precisamos que tenha um construtor dobrecarregado onde não é necessário para nada para a classe
            Product p3 = new Product{
                Item = "produtoooo",
                Price = 541654.11,
                Amount = 25
            };

            


        }
    }

}