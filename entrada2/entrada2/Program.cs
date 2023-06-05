using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            //VALORES LIDOS PELO READLINE SEMPRE SÃO CONVERTIDOS PARA STRING
            //para transformarmos um valor do ReadLine para algo diferente de string, utilizamos o Parse
            //agora ele só irá aceitar números, caso seja inserido uma string, ele retornará um erro!!!
            char sex = char.Parse(Console.ReadLine());
            int yeOld = int.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine($"{name},{sex},{yeOld}, {height}");

            //armazenando em um array
            //pega todas as informações digitadas e as separadas nos espaços
            string[] fullInfo = Console.ReadLine().Split(' ');

            string name2 = fullInfo[0];

            //é necessário utilizar o Parse
            char sex2 = char.Parse(fullInfo[1]);
            int yeOld2 = int.Parse(fullInfo[2]);
            //é necessário colocar o CultureInfo.InvariantCulture para que nossa altura não saia sem o ponto ou virgula
            double height2 = double.Parse(fullInfo[3], CultureInfo.InvariantCulture);

            Console.WriteLine($"{name2}, {sex2}, {yeOld2}, {height2.ToString(CultureInfo.InvariantCulture)}");


        }   
    }
}