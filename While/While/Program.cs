using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite um valor");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            

            // o while funciona como um laço de repetição, que será repetido até que o valor seja false
            //caso x seja maior que zero, ele irá ficar reexecutando esse laço while, até que ele se torne false e continuidade ao código
            while (x > 0)
            {
                //caso o valor digitado se enquadre como true, ele irá reexecutar o código
                Console.WriteLine(Math.Sqrt(x).ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("Digite outro valor");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("valor negativo");
        }
    }
}