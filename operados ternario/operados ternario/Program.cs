using System.Reflection.Metadata;
using System.Threading.Channels;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = 15;

            //basicamente serve como um if else curto, que tem apenas duas coisas para retornar
            //"valor o number seja 15, o valor de resultado será oque vem antes do : ( que no caso sera o valor true)
            //caso seja diferente de 15, o resultado será oque tem depois dos : ( que é o valor falze)
            string resultado = (number == 15) ? "o valor é 15" : "o valor é diferente de 15";

            Console.WriteLine(resultado);
        }
    }
}