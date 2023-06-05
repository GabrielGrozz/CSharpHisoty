using System.Transactions;
using workerProject.Entities.Enums;
using System.Globalization;
using workerProject.Entities;

namespace WorkerProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departament's name: ");
            string departamentName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string workerName = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            //essa é a forma que fazemos para transformarmos uma string em um enum
            WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament dptm = new Departament(departamentName);

            //instanciamos o nosso worker passando os valores como parametro
            Worker worker = new Worker(workerName, workerLevel, baseSalary, dptm);

            Console.Write("How many contract's to this worker?");
            int contracts = int.Parse(Console.ReadLine());
            for(int i = 0; i < contracts; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                //convertendo o dateTime
                DateTime contractDate = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Duration (hours): ");
                int duration = int.Parse(Console.ReadLine());

                //instanciamos um novo contrato para o nosso worker
                HourContract contract = new HourContract(contractDate, valuePerHour, duration);
                //adicionando o contrato no worker
                worker.addContract(contract);
            }

            Console.WriteLine("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Departament: {worker.Departament.Name}");
            Console.WriteLine($"Income for {monthAndYear}: {worker.income(year, month)}");
            Console.WriteLine($"");
            Console.WriteLine($"");






        }
    }
}