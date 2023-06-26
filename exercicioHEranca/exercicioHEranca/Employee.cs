namespace exercicioHEranca
{
    internal class Employee
    {
        public Employee() { }
        public Employee(string name, int hours, double valuePerHour)
        {
            this.name = name;
            this.hours = hours;
            this.valuePerHour = valuePerHour;
        }

        public string name;
        public int hours;
        public double valuePerHour;

        public virtual double payment()
        {
            return valuePerHour * hours;
        }
    }
}
