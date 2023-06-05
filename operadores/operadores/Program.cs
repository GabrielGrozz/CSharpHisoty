using System;
using System.Globalization;

namespace Operadores;

class Aula2
{
    static void Main(string[] args)
    {
        string nome = "Gabriel";
        int idade = 18;
        float salario = 1703.945151f;

        // arredonda para as duas casas decimais SEMPRE ARREDONDANDO OS ULTIMOS VALORES
        Console.WriteLine(salario.ToString("F2"));

        //irá desconsiderar qualquer foramatação de país, como por exemplo a virgula no console
        Console.WriteLine(salario.ToString("F4", CultureInfo.InvariantCulture));

        Console.WriteLine("{0} tem {1} anos e recebe {2:F2}",nome, idade, salario);
        Console.WriteLine($"{nome} tem {idade} anos e recebe {salario:F2}");
        Console.WriteLine(nome + " tem " + idade + " anos e recebe " + salario);


        //OPERADORES DE ATRIBUIÇÂO 
        int a = 10;

        //essas operações mudam o valor da variável A
        //pega o valor de A mais 3
        int b = a += 3;

        //pegar o valor de A menos 5
        int c = a -= 5;

        //pegar o valor de A vezes o valor de 2;
        int d = a *= 2;

        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);

        //pegar o valor e soma mais um depois
        int value = d++;

        //pegar o valor soma um antes e depois atribui o valor da variavel
        int valor = ++d;

    } 

}
