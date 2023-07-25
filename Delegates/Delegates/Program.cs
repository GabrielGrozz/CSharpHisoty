using Delegates.Services;

namespace Course
{

    //delegate é um tipo referencia do c#, serve principalmente para ser referencia para funções
    //poderias fazer isso com interfaces, mas interfacer seriam mais indicadas para coisas com mais estrutura/complexas
    //como aqui será apenas para referencia uma função, podemos se utilizar um delegate

    //essa seria a nossa declaracao do delegate
    delegate double BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 5;

            //essa seria a forma de utilizarmos o delegate, aqui estou usando ele para fazer referencia para um método da nossa classe
            //só relembrando que não invocamos a função aqui, apenas passamos como referencia
            BinaryNumericOperation op = CalcutationService.Soma;

            //assim podemos chamar o método de uma forma menos verbosa
            //aqui é aonde iremo utiliza-la, assim sendo necessário invoca-la
            Console.WriteLine(op(a,b));

            //não podemos chamar outros método que não possuam menos ou mais de um parametro, pois no nosso delegate passamos dois

            //ex
            op = CalcutationService.Square;
            Console.WriteLine(op(10));

        }
    }
}