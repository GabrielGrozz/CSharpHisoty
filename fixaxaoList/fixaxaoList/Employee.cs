
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fixaxaoList
{
    internal class Employee
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public double SalarySet
        {
            set { Salary = value; }
        }

        public static double SalaryIncrease(double salary, double percentage)

        {
            return salary + (salary * (percentage / 100));
        }

    }
}
