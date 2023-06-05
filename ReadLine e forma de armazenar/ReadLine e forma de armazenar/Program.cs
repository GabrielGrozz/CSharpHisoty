using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReadLine serve para que possamos escrever no console e armazenar o dado na memória, ou seja, em uma variável
            string name = Console.ReadLine();
            Console.WriteLine(name);

            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            string word3 = Console.ReadLine();
            Console.WriteLine(word1);
            Console.WriteLine(word2);
            Console.WriteLine(word3);

            //podemos separar as paravras que escrevemos em um Array utilizando métodos co c#
            string phrase = Console.ReadLine();
            //com o método Split podemos definir que o texto será separado por algo, que no momento será o espaço ' '
            //para passarmos um Array, precisamos colocar o [] no começo da declaração
            string[] array = phrase.Split(' ');
            //podemos colocar o Split diretamento no ReadLine "** string[] array = Console.ReadLine().Split(" ") **"


            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
        }
    }
}

