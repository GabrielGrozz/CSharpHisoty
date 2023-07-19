// esse projeto é exclusivo para fixacao, caso voce(eu) não lembre como usar algo, reveja a aula e tente aplicar aqui
// --------------se possível apagar o código após feito, pois ja temos os arquivos com essas bases salvos na pastas com os arquivos

// ----------- GENERICS

using ConsoleApp3.Entities;

//precisamo passar o tipo de valor que será a nossa classe com os <tipoQueSeraUsado>
PrivateService<string> privateService = new PrivateService<string>();

Console.Write("how many values? ");
int quantity = int.Parse(Console.ReadLine());
for (int i = 0; i < quantity; i++)
{
    //privateService.AddValue(int.Parse(Console.ReadLine()));
    privateService.AddValue(Console.ReadLine());

}

Console.WriteLine(" ");
Console.Write("first: ");
Console.WriteLine(privateService.First());
Console.WriteLine(" ");
Console.WriteLine(" ");

privateService.Print();


