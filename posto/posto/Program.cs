Console.WriteLine("Qual o seu conbustivel preferido?");
Console.WriteLine("1 - alcool, 2 - gasolina, 3 - diesel, 4 - finalizar pesquisa");
int preferencia  = int.Parse(Console.ReadLine());

int alcool = 0;
int gasolina = 0;
int diesel = 0;

while(preferencia != 4)
{
    if(preferencia == 1)
    {
        ++alcool;
    }else if (preferencia == 2)
    {
        ++gasolina;
    }else if(preferencia == 3)
    {
        ++diesel;
    }else
    {
        Console.WriteLine("digite um código válido!");
    }

    preferencia = int.Parse(Console.ReadLine());

}

Console.WriteLine("OBRIGADO PELOS DADOS");
Console.WriteLine("ALCOOL: " + alcool);
Console.WriteLine("GASOLINA: " + gasolina);
Console.WriteLine("DIESEL: " + diesel);
