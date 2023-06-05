using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modificadores
{
    internal class Calculator
    {
        public static int editNum(int value)
        {
            return value += 5;
        }
        public static int editNumber(ref int value)
        {
            return value += 10;
        }

    }
}
