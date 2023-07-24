using System.Globalization;

namespace ExtensionsMethods.Extensions
{
    //para podermos utilizar ExtensionsMethods precisamos de uma classe stática
    static internal class DateTimeExtensions
    {
        // o this será oque irá definir que esse método é um ExtensionMethod, o nosso primeiro parametro com o this será para representar
        //o próprio objeto
        public static string TimeSpace(this DateTime date)
        {
            TimeSpan space = DateTime.Now.Subtract(date);

            //se for menor que 24 horas, irá mostrar em forma de hora
            if (space.TotalHours < 24.0)
            {
                return space.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            else
            {
                //se for maior que 24 horas vai mostrar em dias
                return space.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
            }
        }

    }
}
