/*poderiamos fazer esse projeto de vairas formas, uma delas seria usando if e else aqui no próprio programa para tratarmos as excessões e erros, mas
essa seria uma maneira muito ruim por: estar tudo no program, as excessões da classe devem ser tratadas dentro da classe, assim não expondo os tratamentos
para o programa --//-- poderiamos tratar utilizando if e else fazendo com que retornase uma string dentro da classe, mas isso continuaria ruim msm funcionando, 
como se trata de excessões podemos e devemos utilizar as Exceptions para tratar erros e excessões para manter a semantica do código, e tudo isso dentro da classe */
using Exception.ENTITIES;

Console.Write("Room number: ");
int roomNumber = int.Parse(Console.ReadLine());

Console.Write("Check -in date(dd / MM / yyyy): ");
DateTime checkInDate = DateTime.Parse(Console.ReadLine());

Console.Write("Check -out date(dd / MM / yyyy): ");
DateTime checkOuDate = DateTime.Parse(Console.ReadLine());

Reservation reservation = new Reservation(roomNumber, checkInDate, checkOuDate);
Console.WriteLine(reservation);

Console.WriteLine("");
Console.WriteLine("Enter data to update the reservation:");
Console.Write("Check -in date(dd / MM / yyyy): ");
DateTime newCheckInDate = DateTime.Parse(Console.ReadLine());

Console.Write("Check -out date(dd / MM / yyyy): ");
DateTime newCheckOuDate = DateTime.Parse(Console.ReadLine());
reservation = new Reservation(roomNumber, checkInDate, checkOuDate);

