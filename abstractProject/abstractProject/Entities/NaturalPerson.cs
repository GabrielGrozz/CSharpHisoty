namespace AbstractProject.Entities
{
    internal class NaturalPerson : PersonShape
    {
        internal string Name { get; set; }
        internal double AnualIncome { get; set; }
        internal double HealthSpending { get; set; }

        public NaturalPerson(string name, double anualIncome, double healthSpending) : base(name, anualIncome)
        {
            HealthSpending = healthSpending;
        }

        //método para saber quanto uma pessoa fisica irá pagar
        internal override double TaxCalc()
        {
            double TotalTaxPaid;

            if (AnualIncome < 20000.00)
            {
                TotalTaxPaid = (AnualIncome * 0.15) - (HealthSpending * 0.50);
            }
            else
            {
                TotalTaxPaid = (AnualIncome * 0.25) - (HealthSpending * 0.50);
            }

            return TotalTaxPaid;
        }
    }
}
