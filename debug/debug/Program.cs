using System;

namespace Couser
{
    class Program
    { 
        static void Main(string[] args)
        {
            int val1 = int.Parse(Console.ReadLine());

            int val2 = int.Parse(Console.ReadLine());


            //com o debug podemos acompanhar o andamento do nosso código
            // com F9 podemos marcar um breackpoint, que a partir dele nosso código será executado passo a passo
            // co0m o F5 podemos começar o debug e com shift F5 paramos o debug
            int val3 = int.Parse(Console.ReadLine());

            //podemos utilizar o F10 para executarmos passo a passo nosso código a partir do breakpoint
            //com o F11 podemos entrar dentro do métodos e como ele é executado passo a passo também, coisa que o F10 não faz



            //aqui nos chamamos o função e passamos os parâmetros int maiorValor = Maior (val1, val2, val3);
            int maiorValor = Maior(val1, val2, val3);

            Console.WriteLine($"maior número: {maiorValor}");

        }
        //podemos fazer funções também, para isso precisamo passar o tipo de valor //que ela irá nos retornar (int) e os tipos dos parâmetro.
        static int Maior(int a, int b, int c)
        {
            int m;

            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c && b > a)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
    }

}