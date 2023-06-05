using System.Globalization;
using primeiro_exercicio2;

Console.WriteLine("Digite o nome do primeiro funcionário");
string firstEmployee = Console.ReadLine();

Console.WriteLine("Agora o salário dele");
double firstEmployeeSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Employee employee1 = new Employee();
employee1.Name = firstEmployee;
employee1.Salary = firstEmployeeSalary;

Console.WriteLine("Digite o nome do segundo funcionário");
string secondEmployee = Console.ReadLine();
Console.WriteLine("Agora o salário dele");
double secondEmployeeSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Employee employee2 = new Employee();
employee2.Name = secondEmployee;
employee2.Salary = secondEmployeeSalary;

double averageSalary = (employee1.Salary + employee2.Salary) / 2;

Console.WriteLine($"a média salárial entre os dois funcionários é {averageSalary.ToString("F2", CultureInfo.InvariantCulture)}");

