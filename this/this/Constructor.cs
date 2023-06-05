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



        // *********************************************************************************************************************************************************************
        // *********************************************************************************************************************************************************************
        // *********************************************************************************************************************************************************************
        // *************************************************************  THIS   ***********************************************************************************************

        // a palavra this é utilizada para referenciar o próprio elemento, como em parametros
        //caso não utilizemos this nessa situação, o interpretador não irá saber oque o Item,Price,Amount está referenciando
        //se é uma varialvel local ou um parametro, nesse caso, precisamos colocar a palavra this na variavel local, para que o interpretador 
        //consiga lidar com essa situação
        public Product(string Item, double Price, int Amount)
        {
            this.Item = Item;
            this.Price = Price;
            this.Amount = Amount;
        }


        public Product()
        {
            Amount = 0;
        }

        //podemos usa-li para referenciar outro construtor também como aqui, para não precisarmos setar uma quantidade aqui,
        //usamos o :this, para referenciar o construtor default, para aproveitar o fata de que ele ja possui uma quantidade setada para 0
        //assim nossa quantidade também será 0 no construtor abaixo
        public Product(string nome, double valor) : this() 
        {
            Item = nome;
            Price = valor;

        }




        // *********************************************************************************************************************************************************************
        // *********************************************************************************************************************************************************************
        // *********************************************************************************************************************************************************************
        // *********************************************************************************************************************************************************************


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
