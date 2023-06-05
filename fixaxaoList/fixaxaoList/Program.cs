using fixaxaoList;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //quantidade que será registrada no sistema
            Console.Write("How many employees will be registered? ");
            int quanty = int.Parse(Console.ReadLine());

            //criando a lista de empregados
            List<Employee> employees = new List<Employee>();

            //setando os dados dos empregados
            for (int i = 0; i < quanty; i++)
            {
                Console.WriteLine($"Employee #{i+1}");
                Console.Write("ID :");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name :");
                string name = Console.ReadLine();

                Console.Write("Salary :");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //adicionando os empregados na lista
                employees.Add(new Employee(id, name, salary));
            }

            //selecionando qual empregado irá receber aumento
            Console.Write("Enter the employee id that will have salary increase: ");
            int idSalaryIncrease = int.Parse(Console.ReadLine());

            //a porcentagem do aumento
            Console.Write("Enter the percentage: ");
            double salaryIncreasePercentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //achando o empregado pelo ID
            Employee employeeSalaryIncrease = employees.Find(x => x.Id == idSalaryIncrease);

            //achando o index do funcionário pelo ID e criando uma variável com salário do funcionário
            int index = employees.FindIndex(x => x.Id == idSalaryIncrease);
            double salaryWillIncrease = employeeSalaryIncrease.Salary;

            //criando uma váriavel com o método que irá calcular o aumento 
            double salaryIncreased = Employee.SalaryIncrease(salaryWillIncrease, salaryIncreasePercentage);

            //setando o aumento
            employees[index].SalarySet = salaryIncreased;

            //exibindo o salário dos funcionários no console
            Console.WriteLine("Updated list of employees:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}, Salary: ${employee.Salary.ToString("F2", CultureInfo.InvariantCulture)}");
            }


        }
    }
}