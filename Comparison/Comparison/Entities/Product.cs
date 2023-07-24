using System.Diagnostics.CodeAnalysis;

namespace Comparison.Entities
{
    internal class Product //: IComparable
    {
        public string Name { get; set; }
        public double Value { get; set; }

        //podemos ordenar a nossa lista implementando o metodo CompareTo do IComparable, porém temos outras formas de ordenar uma lista
        //Com o CompareTo nós não fechamos a nossa classe para implementações, pois toda vez que quisermos mudar a forma como a lista
        // é ordenada deveremos abrir a classe, por isso usamos outras formas
        //public int CompareTo(object obj)
        //{
        //    Product p = obj as Product;
        //    return Name.CompareTo(p.Name);
        //}
    }
        
}
