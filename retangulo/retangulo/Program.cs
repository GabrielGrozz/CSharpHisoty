using System.Globalization;
using retangulo;


Rectangle r1 = new Rectangle();
Console.WriteLine("digite a largura de um retangulo:");
r1.Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) ;


Console.WriteLine("digite a altura de um retangulo:");
r1.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("AREA: " + r1.Area().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("PERIMETRO: " + r1.Perimeter().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("DIAGONAL:" + r1.Diagonal().ToString("F2", CultureInfo.InvariantCulture));