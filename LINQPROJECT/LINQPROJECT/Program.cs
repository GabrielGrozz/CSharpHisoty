using fixProjectLINQ.Entities;
using System.Globalization;

Console.Write("Enter the path: ");
string path = Console.ReadLine();


List<Employee> employees = new List<Employee>();

using (StreamReader sr = new StreamReader(path))
{
    while (!sr.EndOfStream)
    {
        string[] employeeData = sr.ReadLine().Split(',');
        string name = employeeData[0];
        string email = employeeData[1];
        double salary = double.Parse(employeeData[2], CultureInfo.InvariantCulture);

        employees.Add(new Employee(name, email, salary));
    };
}

//vai ordernar nossa lista por ordem alfabética
employees.Sort((e1, e2) => e1.Name.CompareTo(e2.Name));

Console.WriteLine("EMPLOYEES DATA: ");
foreach (Employee employee in employees)
{
    Console.WriteLine($"{employee.Name}, {employee.Email}, {employee.Salary.ToString("F2", CultureInfo.InvariantCulture)}");
}

Console.WriteLine(' ');
Console.WriteLine("Enter a min salary: ");
double minSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

var employeeMinSalary = employees.Where(x => x.Salary >= minSalary).OrderBy(x => x.Name);

Console.WriteLine($"Employee with the salary is bigger than {minSalary}");
foreach (Employee employee in employeeMinSalary)
{
    Console.WriteLine($"{employee.Name}, {employee.Email}, {employee.Salary.ToString("F2", CultureInfo.InvariantCulture)}");
}

Console.WriteLine(' ');
Console.WriteLine("soma dos salários de todo que começam com G:");
double employeeM = employees.Where(x => x.Name[0] == 'g').Select(x => x.Salary).Aggregate((x, y) => x + y);

Console.WriteLine(employeeM);
