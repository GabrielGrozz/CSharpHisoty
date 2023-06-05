using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //trataremos do DateTime, qu eé utilizado para representar as horas aqui no C#

            //dattime.now mosta o horário de agora, de acordo com o gmt da máquina
            DateTime data1 = DateTime.Now;
            Console.WriteLine(data1);

            //datetime.Utcnow mosta a data de acordo com o gmt
            DateTime data2 = DateTime.UtcNow;
            Console.WriteLine(data2);

            //o .ticks irá mostrar o horário como ele é na maquina, que é em ticks, que o computador irá calcular para deixa-lo de forma
            //legível
            Console.WriteLine(data1.Ticks);


            //date time possui construtores também

            //aqui iremos instaciar um datetime com o ano 2000 do mes 5 do dia 23 as 00horas
            DateTime data3 = new DateTime(2000,05,23);
            Console.WriteLine(data3);

            //aqui iremos instanciar um datetime do ano 2015 do mes 8 do dia 12 as 15 horas 23 minutos e 48 segundos
            DateTime data4 = new DateTime(2015, 08, 12, 15, 23, 48);
            Console.WriteLine(data4);

            //aqui colocamos os milisegundo tambèm, porém eles não irão aparecer devido a formatação em que ele está, que desconsidera os ms
            DateTime data5 = new DateTime(2015, 08, 12, 15, 23, 42, 600);
            Console.WriteLine(data5);

            //TEMOS OS BUILDERS TAMBÉM

            //com o .today temos a data de hoje, mas com o horário zerado
            DateTime data6 = DateTime.Today;
            Console.WriteLine(data6);


            //PODEMOS GERAR NOSSAS PRÓPRIAS DATAS TAMBÉM

            //com o .Parse, ele irá gerar uma data de acordo com a string passada, ele aceita varios tipos de formatação
            DateTime data7 = DateTime.Parse("2014-09-23");
            Console.WriteLine(data7);

            //em outra formatação
            DateTime data8 = DateTime.Parse("2010/05/12 23:10:14");
            Console.WriteLine(data8);

            //podemos definir nossa própria formatação também
            //aqui dizemos que oque será o ano mes e dia, e precisamos do cultureinfo
            DateTime d9 = DateTime.ParseExact("09-2017-30 19:04:12", "MM-yyyy-dd mm:HH:ss",CultureInfo.InvariantCulture );
            Console.WriteLine(d9);







        }
    }
}