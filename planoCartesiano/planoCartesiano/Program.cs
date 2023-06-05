Console.WriteLine("escreva dois valores do polano cartesiano");
string[] values = Console.ReadLine().Split(' ');

double x = double.Parse(values[0]);
double y  = double.Parse(values[1]);

if(x ==0 && y == 0)
{
    Console.WriteLine("centro do plano");
}
else if (x > 0 && y > 0)
{
    Console.WriteLine("parte superior direito do plano cartesiano");
}else if (x > 0 && y < 0)
{
    Console.WriteLine("parte inferior direto do plano cartesiano");
}else if (x < 0 && y > 0)
{
    Console.WriteLine("parte superior esquerdo do plano cartesioano");
}
else
{
    Console.WriteLine("parte inferior esquerdo do plano cartesiano");
}