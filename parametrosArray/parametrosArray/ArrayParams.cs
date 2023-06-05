using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parametrosArray
{
    class ArrayParams
    {


        //com esses parametros, estamos passando um array com o nome de numbers como parametro
        //o params nos permite inserir os dados diretamente nos parametros, assim não sendo necessáio usarmos um "new int[]" para fazermos isso
        public static int Soma(params int[] numbers)
        {
            {
                int value = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    value += numbers[i];
                }
                return value;
            }
        }


    }

}
