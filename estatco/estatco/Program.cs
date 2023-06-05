using estatco;

namespace Course
{
    class Program {

        //membros estáticos são coisas que sempre podemos chamar sem envolver um contexto necessário, como o Math, não precisamos
        //definir oque será o Math, pois ele ja está definido, que seria diferente caso tivessemos que instancialo

        //quando formos criar métodos fora do nosso escopo principal, e ele ser estático, o nosso método também deverá ser static, caso
        //contrário, não será possível utilizado

        //isso também se aplica a dados que estão fora
        //caso não colocasemos o static, ele retornária um erro
        static string data = "valor estático";
        static void Main(string[] args)
        {
            Console.WriteLine(data);
            Console.WriteLine(metodo());

            Console.WriteLine(Calculadora.Pi());
            Console.WriteLine(Calculadora.Plus(5,7));
        }

        static string metodo()
        {
            return "trabalhando com membros estáticos!!";
        }
    }

}