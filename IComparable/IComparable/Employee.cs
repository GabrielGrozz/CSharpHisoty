using System.Globalization;
using System;


namespace IComparadbleClass
{   //                      utilizando o IComparable
    internal class Employee : IComparable
    {
        public string Name {  get; set; }
        public double Salary{ get; set; }

        public Employee(string csvEmployee) {
            // Se simplesmente fizermos assim ele irá nos retornar uma excetion, pois não é possível comprar dois elementos do array, para que isso funcione iremos utilizar o IComparable
            string[] list = csvEmployee.Split(',');
            Name = list[0];
            Salary = double.Parse(list[1], CultureInfo.InvariantCulture);
            
        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);

        }

        //esse método serve para compararmos as classes
        public int CompareTo(object obj)
        {
            //caso o obj passado pélo parametro não seja do tipo employee ele irá me retornar uma exception.
            if (!(obj is Employee)) {
                throw new ArgumentException("object not is a Employee");
            }

            //aqui fazemos um downcasting do obj 
            Employee other = obj as Employee;

            //aqui iremos ordenar a nossa lista pelo Name, mas poderia ser pelo Salary tbm
            return Name.CompareTo(other.Name);

        }
    }
}
