using fixArray;

Console.Write("Quantos quartos serão alugados?");
int qtd = int.Parse(Console.ReadLine());

Student[] hotelRooms = new Student[9];

for (int i = 0; i < qtd; i++)
{
    Console.WriteLine($"Aluguel #{i}");
    Console.Write("Digite o nome do estudante: ");
    string name = Console.ReadLine();

    Console.Write("Digite o email do estudante: ");
    string email = Console.ReadLine();

    Console.Write("Em qual quarto ele irá ficar?");
    int room = int.Parse(Console.ReadLine());

    hotelRooms[room] = new Student(name, email);
}



for (int i = 0; i < 9; i++)
{
    //quando um slot do array não é ocuopado, ele será null, assim podemos utilizar este fato para conferirmos quais items estão ocupados
    if( hotelRooms[i] != null)
    {
        Console.WriteLine($"O quarto {hotelRooms[i].Room} está ocupado por {hotelRooms[i].Name}, do email {hotelRooms[i].Email}");
    }
}

