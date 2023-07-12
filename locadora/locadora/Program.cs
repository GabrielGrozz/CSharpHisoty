using locadora.ENTITIES;
using locadora.SERVICE;

Console.WriteLine("Enter rental data:");

Console.Write("Car model: ");
string carModel = Console.ReadLine();

Console.Write("Pickup date (dd/MM/yyyy hh:mm): ");
DateTime pickupDate = DateTime.Parse(Console.ReadLine());

Console.Write("Return date (dd/MM/yyyy hh:mm): ");
DateTime returnDate = DateTime.Parse(Console.ReadLine());

Console.Write("Enter price per hour");
double pricePerHour = double.Parse(Console.ReadLine());

Console.Write("Enter price per day");
double pricePerDay = double.Parse(Console.ReadLine());

//como o vehicle dentro de CarRental é uma classe vehicle, precisamos instanciar uma classe de vehicle antes de passala como argumento
Vehicle vehicle = new Vehicle(carModel);
CarRental carRental = new CarRental(pickupDate, returnDate, vehicle);

RentalService rentalService = new RentalService(pricePerHour, pricePerDay);

rentalService.ProcessInvoice(carRental);

Console.WriteLine("");
Console.WriteLine("INVOICE:");
Console.WriteLine();
Console.Write("Basic payment: ");
Console.Write("Tax: ");
Console.Write("Total payment: ");
