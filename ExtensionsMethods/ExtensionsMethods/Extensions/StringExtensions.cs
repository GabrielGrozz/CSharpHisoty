using System.Globalization;

namespace ExtensionsMethods.Extensions
{
    public static class StringExtensions
    {
        //retorna a string que chamou o método com a quantidade de string passada
        public static String StringSize(this string strObj, int count)
        {
            if (strObj.Length < count)
            {
                return strObj;
            }
            else
            {
                return strObj.Substring(0, count) + "...";

            }

        }
    }
}
