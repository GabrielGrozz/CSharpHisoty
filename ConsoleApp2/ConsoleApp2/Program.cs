Console.WriteLine("Bem vindo a nossa cefeteria!!");
Console.WriteLine("Oque você deseja?");
Console.WriteLine("1-café(R$2,50)   2-cappucino(R$4,50)  3-café gelado(R$3,00)  4-expresso(R$5,00)");
Console.WriteLine("4-Finalizar pedido");

bool payTheBill = false;
double bill = 0.00;


while (!payTheBill)
{
    int request = int.Parse(Console.ReadLine());

    if (request == 0)
    {
        bill += 2.5;
        Console.WriteLine("Quer mais alguma coisa?");
    }
    else if (request == 1)
    {
        bill += 4.5;
        Console.WriteLine("Quer mais alguma coisa?");
    }
    else if(request == 2)
    {
        bill += 3;
        Console.WriteLine("Quer mais alguma coisa?");
    }
    else if (request == 3)
    {
        bill += 5;
        Console.WriteLine("Quer mais alguma coisa?");
    }
    else if (request == 4)
    {
        payTheBill = true;
    }
    else
    {
        Console.WriteLine("Escolha um pedido válido");
    }
}

Console.WriteLine($"Sua conta ficou R${bill:F2}");