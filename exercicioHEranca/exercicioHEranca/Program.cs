using exercicioHEranca;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int employeeQuantity = int.Parse(Console.ReadLine());

            for (int i = 0; i < employeeQuantity; i++)
            {
                Console.WriteLine($"Employee #{i + 1} data:");
                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour:");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                if (outsourced == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    //Employee employee = new OutsourceEmployee(name, hours, valuePerHour, additionalCharge);
                    //employees.Add(employee);
                    //podemos adicionar dessa forma ou utilizarmos a abaixo

                    employees.Add(new OutsourceEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    Employee employee = new Employee(name, hours, valuePerHour);
                    employees.Add(employee);
                }
            }

            Console.WriteLine("PAYMENTS:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.Name}, R${employee.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }

        }
    }
}