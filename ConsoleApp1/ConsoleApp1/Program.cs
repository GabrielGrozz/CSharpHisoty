using System.Globalization;

Console.WriteLine("digite três valores com ponto flutuante");
string[] valores = Console.ReadLine().Split(' ');

double val1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
double val2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
double val3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

Console.WriteLine((val1 * val3 / 2).ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine((Math.PI * Math.Pow(val3, 2.00)).ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine(((val1 + val2) * val3 / 2).ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine(Math.Pow(val2, 2.00).ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine((val1 * val2).ToString("F4", CultureInfo.InvariantCulture));

