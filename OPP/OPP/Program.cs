using OPP;
using System;
using System.Globalization;


//POO
namespace Course
{
    class Project
    {
        static void Main(string[] args)
        {
            //quando utilizamos uma classe no nosso projeto, precisamos setar o tipo como a classe e instanciar a classe que possamos atribuir os valores dessa classe na nossa váriavel
            //quando utilizarmos a instancia de uma classe, precisamos chama-la utilizando o "new" e os parenteses()
            Triangle x = new Triangle();

            //agora temos duas váriaveis que foram instanciadas da classe Triângulo, apesar de terem o mesmo escopo, possuem valores diferentes atribuidas nelas
            Triangle y = new Triangle();

            Console.WriteLine("digite as 3 medidas de um triângulo");
            //aqui utilizamos os valores que são do Triangle, que seria a classe que foi instanciada
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("digite as 3 medidas do segundo triângulo");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            //quando formos utilizar um método de outro, é necessário chamar ele utilizando os ()
            Console.WriteLine($"a área do primeiro trinângulo é {x.Area().ToString("F3", CultureInfo.InvariantCulture)}");

            Console.WriteLine($"a área do segundo trinângulo é {y.Area().ToString("F3", CultureInfo.InvariantCulture)}");

            if (x.Area() > y.Area() )
            {
                Console.WriteLine($"a maior área é área do primeiro: {x.Area().ToString("F3",CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine($"a maior área é área do segundo: {y.Area().ToString("F3", CultureInfo.InvariantCulture)}");
            }

        }
    }
}