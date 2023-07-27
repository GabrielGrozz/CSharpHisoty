//nesse projeto iremo falar sobre o LINQ

//O LINQ em si seria um conjunto de tecnologias usadas na integração de funcionalidades de consulta do c#
//com eles métodos chamados a partir das coleções, auxilio do intellisense e as consultas são objestos
//de consulta de primeira classe]

/* para utilizar ele precisamos de três coisas:
 * uma base de dados(planilha, List, Array, Banco de dados,...)
 * Definir a Query(usar os métodos e definir oque queremos que aconteça)
 * executar a Query(chamar a query, seja com um foreach ou ForEach
 * */

using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Course
{
    class Program
    {
        delegate int MyFunction(int x);
        public static void Main(string[] args)
        {
            Func<double, bool> DelCalcUnder100 = calcUnder100;
            Func<double, double> DelMultiValue = multiValue;


            //esse será a nossa base de dados    
            double[] values = new double[] { 45, 864, 4, 8, 48, 654, 89, 48, 74, 62, 65, 8, 4, 8970, 4, 7, 10, 0, 15, 40, 465 };

            //esse será a nossa query, podemos tanto usar uma lambda quanto um delegate Predicate
            //esse seria o exemplo onde passamos expressões lambda como predicado
            //tanto o Where quanto o Select me retornam um IEnumerable, com isso temos os métodos das coleções a nossa disposição
            //nós usamos o Where para filtrar os valores que queriamos e o Select para utilizar uma lógica emcima desses valores
            //que foram filtrados

            //qualquer uma das três formas funciona e terá o mesmo resultado
            var under100 = values.Where(x => x <= 100).Select(x => x * 0.5);
           // var under100 = values.Where(DelCalcUnder100).Select(multiValue);
            //var under100 = values.Where(calcUnder100).Select(multiValue);


            //podemos também utilizar os delegates para fazer a mesma lógica acima

            //esse seria a nossa execução dad Query
            foreach (var value in under100)
            {
                Console.WriteLine(value);
            }


            static bool calcUnder100(double value)
            {

                return value <= 100;
            }

            static double multiValue(double value)
            {
                return value * 0.5;

            }
        }
    }
}