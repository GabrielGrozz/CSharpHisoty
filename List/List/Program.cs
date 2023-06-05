using System.Collections.Generic;
//listas são parecidas com arrays, todos os dados devem ser do mesmo tipo, são organizadas por index, a diferença é que diferente dos vetores, elas podem ser iniciadas vazias

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //primeiros chamamos o List<passamos o tipo de dado> e o nome da lista, depois só instanciamos
            //podemos inicia-la vazia
            List<string> lista = new List<string>();
            //ou iniciala com os valores ja declarados
            List<string> lista2 = new List<string>() {"gabriel","davi","pietra"};
            foreach( string str in lista2)
            {
                Console.WriteLine(str);
            }


            //em vantagens temos o fato que podemos adicionar e remover os itens dela a qualquer momentos, pois ela possui tamanho variável
            //porém o acesso a ela é sequencial, ou seja, para acessarmos o item do index 50, vamos ter que passar por todos os indexs anteriores a ele para dai sim acessa-lo

        }
    }
}