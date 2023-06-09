﻿namespace exercicioHEranca
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee() { }
        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        //virtual para podermons sobreescrever esse metodo nas subclasses
        public virtual double Payment()
        {
            return ValuePerHour * Hours;
        }
    }
}
