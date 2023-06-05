using System.Globalization;

Console.Write("digite o código do lanche(1, 2, 3, 4, 5) mais a quantidade desejada: ");
string[] data = Console.ReadLine().Split(' ');

int lanche = int.Parse(data[0]);
int quantidade = int.Parse(data[1]);

double valorDoLanche = 0;

if (lanche == 1)
{
    valorDoLanche = 4.0;
}else if (lanche == 2)
{
    valorDoLanche = 4.5;
}else if(lanche == 3)
{
    valorDoLanche = 5.00;
}else if (lanche == 4)
{
    valorDoLanche = 2.00;
}else if (lanche == 5){
    valorDoLanche = 1.5;
}
else
{
    Console.WriteLine("o código do lanche está invalido");
}

double valorTotal = (valorDoLanche * quantidade);


Console.WriteLine($" o total da sua compra foi R${valorTotal.ToString("F2", CultureInfo.InvariantCulture)} Reais");