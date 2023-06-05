using System;

namespace Course
{

    class Program
    {
        static void Main(string[] args)
        {
            //temos as operações + - / % que funcionam igual ao JavaScript
            // * % - sempre se sobresaem em cima de + e -, a não ser que eles estejam entre parenteses 
            //porém com algumas diferenças

            //como se tratam de dois números inteiros, o interpretador irá cortar os casas decimais
            //para resolver isso podemos fazer um casting, ou adicionar as casas decimais diretamente nos valores
            double div1 = (double)7 / 2;
            double div2 = 7.0 / 2.0;
            Console.WriteLine(div1);
            Console.WriteLine(div2);

            //podemos declarar varias váriaveis do mesmo tipo de uma única vez
            double a = 1.0, b = -3.0, c = -4.0;

            //temos operações matemáticas como no JavaScript
            //Math.Pow seria para potenciação, sendo o primeiro valor a base e o segundo a potência
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            // é necesário () entre as operáções para organizar a ordem em que elas irão ser feitas
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"{delta} - valor de delta");
            Console.WriteLine(x1);
            Console.WriteLine(x2);

        }
    }
}
