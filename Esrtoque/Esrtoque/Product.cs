using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esrtoque
{
    internal class Product
    {
        public string Item;
        public double Price;
        public int Amount;

        public double TotalPrice()
        {
            double total = Price * Amount;
            return total;
        }

        //precisamos colocar o tipo de dado que irá ser retornado e o tipo do paramêtro que foi passado
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

        //com o override, ela veio de outra classe e serve para adicionarmos uma string para representarmos o objeto, com isso só iremos precisar 
        //adicionar ela no nosso código, e ela irá retornar essa string
        public override string ToString()
        {   
            //agora toda vez que só chamarmos essa classe, ela irá retornar essa frase como default
            return $"Dados - Nome: {Item}; Preço: {Price.ToString("F2", CultureInfo.InvariantCulture)}; Quantidade: {Amount}; Total:{TotalPrice().ToString("F2", CultureInfo.InvariantCulture)}";
                
        }
    }
}
