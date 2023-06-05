using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace construtores
{
    internal class Product
    {
        public string Item;
        public double Price;
        public int Amount;

        //podemos parametrar as entradas de um construtor, para que assim nossa classe ja receba os dados de forma obrigatória quando ele for instanciado

        //dessa forma que fizemos, quando esse construtor for chamado, ele obrigatóriamente irá precisar que os dados ja sejam passados
        public Product(string nome, double valor, int quantidade)
        {
            //aqui apenas passamos os valores que recebemos do construtor para a classe
            Item = nome;
            Price = valor;
            Amount = quantidade;
        }

        //podemos fazer uma sobrecarga, que seria fazer com que o mesmo construtor possar receber valores de formas diferentes
        //ele deve ter o mesmo nome que o construtor
        //agora podemos passar tanto informando nome preco e a quantidade para o construtor, como podemos informar apenas o nome e o preco e setarmos uma quantidade padrao
        public Product(string nome, double valor)
        {
            Item = nome;
            Price = valor;
            Amount = 5;
        }

        public double TotalPrice()
        {
            double total = Price * Amount;
            return total;
        }

        public int AddItem(int quantity)
        {
            int total = Amount += quantity;
            return total;
        }

        public int RemoveItem(int quantity)
        {
            int total = Amount -= quantity;
            return total;
        }
        public override string ToString()
        {
            return $"Dados - Nome: {Item}; Preço: {Price.ToString("F2", CultureInfo.InvariantCulture)}; Quantidade: {Amount}; Total:{TotalPrice().ToString("F2", CultureInfo.InvariantCulture)}";

        }
    }
}
