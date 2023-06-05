using System;
//referencia ao namespace System que contem funções básicas de manipulçaão de programas

namespace FirstProject
//namespace é um agrupamento de classes relacionadas
{
    class Program
    {
        static void Main(string[] args)
        // é uma declaração para identifcar o entry poinT(PONTO DE ENTRADA) da aplicação
        {

            //principais tipos de variáveis

            //vai de -128 a 127 sendo apenas números
            sbyte tipo1 = 127;

            // de 0 a 255
            byte tipo2 = 255;

            //é grande...
            int tipo3 = 564784874;

            //para números quebrados
            float tipofloat = 2.5f;

            //QUANDO FOR APENAS UM CARACTER, É ASPAS SIMPLES
            char tipo4 = 'P';

            char tipo4e5 = '\u0041';

            //QUANDO FOR MAIS DE 1 CARACTER, SÃO ASPAS DUPLAS
            string nome = "Gabriel";

            //para booleanos
            bool tipo5 = true;

            //Console.Write não possui qyebra de linha
            //Console.WriteLine possui quebra de linha

            Console.WriteLine(tipo1);
            Console.WriteLine(tipo2);
            Console.WriteLine(tipo3);
            Console.WriteLine(tipo4);
            Console.WriteLine(nome);
            Console.WriteLine(tipo4e5);
            Console.WriteLine(tipofloat);
            Console.WriteLine(tipo5);

        }
    }
}
