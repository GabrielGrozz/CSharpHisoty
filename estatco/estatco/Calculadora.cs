using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estatco
{
    internal class Calculadora
    {

        //esses dois métodos são estáticos, pois independente do que houver, o escopo interno não irá alterar o retultado
        // com isso podemos utilizar a nomeclatura static apóso public, assim não sendo mais necessário instaciar
        // a classe para podermos utilizar esses métodos
        public static double Pi()
        {
            return (double)Math.PI;
        }
        public static int Plus(int a, int b)
        {
            int soma = a + b;
            return soma;
        }
    }

}
