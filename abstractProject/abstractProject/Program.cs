using System.Globalization;
using AbstractProject.Entities;

Console.Write("Enter the number of tax payer: ");
int taxPayersQuantity = int.Parse(Console.ReadLine());

List<PersonShape> personsList = new List<PersonShape>();
double TotalTaxes = 0;

for (int i = 0; i < taxPayersQuantity; i++)
{
    Console.WriteLine($"Tax payer #{i + 1} data:");

    Console.Write("Individual or company (i/c)? ");
    char typeOfPerson = char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string personName = Console.ReadLine();

    Console.Write("Anual income: ");
    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


    if (typeOfPerson == 'i')
    {
        Console.Write("Health expenditures: ");
        double healthExpending = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        personsList.Add(new NaturalPerson(personName, anualIncome, healthExpending));

    }
    else if (typeOfPerson == 'c')
    {
        Console.Write("Number of Employees: ");
        int employeesQuantity = int.Parse(Console.ReadLine());

        personsList.Add(new LegalPerson(personName, anualIncome, employeesQuantity));
    }
    else
    {
        Console.WriteLine("Tipo de pessoa invalido!!!");
    }
}

Console.WriteLine("TAXES PAID:");

foreach (PersonShape personShape in personsList)
{
    Console.WriteLine($"{personShape.Name}: ${personShape.TaxCalc().ToString("F2", CultureInfo.InvariantCulture)}");
    TotalTaxes += personShape.TaxCalc();
}

Console.WriteLine("TOTAL TAXES: $" + TotalTaxes.ToString("F2", CultureInfo.InvariantCulture));
