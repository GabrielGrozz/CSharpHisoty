Console.Write("digite quantos números você irá digitar :");
int x = int.Parse(Console.ReadLine());


int soma = 0;


//com o laço for, podemos fazer uma repetição até que a condição seja true, que aqui seria o valor de i ser igual a x
//enquanto ele não fosse true, iria incremetar o valor que digitamos em "soma" e nos retornar o valor na tela quando o laço terminar
for (int i = 1; i <= x; i++)
{

    Console.Write($"Digite o {i}º valor: ");
    int value = int.Parse(Console.ReadLine());

    soma += value;

}

Console.WriteLine($"o total da sua some é {soma}");