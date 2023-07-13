using System.Globalization;
using locadora.ENTITIES;
using locadora.SERVICE;

Console.WriteLine("Enter rental data:");

Console.Write("Car model: ");
string carModel = Console.ReadLine();

Console.Write("Pickup date (dd/MM/yyyy hh:mm): ");  //iremos traduzir exatamente a hora que formos passar, para isso iremos usar o ParseExact do DateTime, com o provider cultureInfo
DateTime pickupDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

Console.Write("Return date (dd/MM/yyyy hh:mm): ");
DateTime returnDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

Console.Write("Enter price per hour: ");
double pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Enter price per day: ");
double pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//como o vehicle dentro de CarRental é uma classe vehicle, precisamos instanciar uma classe de vehicle antes de passala como argumento
Vehicle vehicle = new Vehicle(carModel);
CarRental carRental = new CarRental(pickupDate, returnDate, vehicle);
ItaxService brazilTax = new BrazilTaxService();

RentalService rentalService = new RentalService(pricePerHour, pricePerDay, brazilTax);

rentalService.ProcessInvoice(carRental);

Console.WriteLine("");
Console.WriteLine("INVOICE:");
Console.WriteLine(carRental.Invoice);

