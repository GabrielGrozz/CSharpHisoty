namespace AbstractProject.Entities
{
    internal abstract class PersonShape
    {
        internal string Name { get; set; }
        internal double AnualIncome { get; set; }

        protected PersonShape(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        internal abstract double TaxCalc();
    }
}
