using System;

namespace Program
{
    class Conversão { 
        static void Main(string[] args)
        {

            //podemos transformar um valor float em double sem problemas, pois os dois partem do mesmo princípio(implicita)
            float valor = 2.5f;
            double valor2 = valor;
            Console.WriteLine(valor2);

            //Porém caso transformemos um valor double em float, ele nos alerta-rá que poderá ocorrer perca de informação pela -
            //diferença de bytes de cada variável, assim sendo necessário deixar essa conversão de for explicita(explicita)
            // o float entre parenteses seria um casting, que seria a forma explicita
            double valor3 = 3.9;
            float valor4 = (float) valor3;
            Console.WriteLine(valor4);

            //aqui um exemplo da perca de informação  que pode ocorrer
            double valor5 = 7.65498;
            int valor6 = (int)valor5;
            Console.WriteLine(valor6);

            //aqui pode ocorrer uma perca de informação, mesmo o valor9 sendo double, assim sendo necessário fazer um casting
            int valor7 = 7;
            int valor8 = 2;
            double valor9 = (double)valor7 / valor8;
            Console.WriteLine(valor9);
        }
    }
}

