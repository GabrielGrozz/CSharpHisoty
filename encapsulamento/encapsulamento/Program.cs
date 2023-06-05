using encapsulamento;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //por questã o de boa pratica podemos organizar nosso projeto por atributos, propriedades, construtores, propriedades custom e depois os metodos, nessa ordem

            Encapsulamento user = new Encapsulamento("Gabriel", 1703.50, 18);

            //o conceito de encapsulamento é que algo entregue o esperado, sem nos deixar acessar internamente cada processo
            //não podemos acessar o user.Name pelo fato de que ele está definido como private, seja para exibir ou alterar
            //para termo acesso a ele precisamos criar métodos getters e setters
            //Console.WriteLine(user.Name);

            //como se trata de uma variavel privada usamos o getter dela
            Console.WriteLine(user.GetName());
            //para alterar o valor utilizamos um setter
            user.SetName("krita");
            Console.WriteLine(user.GetName());

            //USANDO PROPRIETIES
            Console.WriteLine(user.Salario);
            user.Salario = 1300.00;
            Console.WriteLine(user.Salario);

            Console.WriteLine("idade: " + user.Idade);
        }

    }
}