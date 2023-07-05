namespace AbstractProject.Entities
{
    internal class LegalPerson : PersonShape
    {
        internal string Name { get; set; }
        internal double AnualIncome { get; set; }
        internal int EmployeeQuantity { get; set; }

        public LegalPerson(string name, double anualIncome, int employeeQuantity) : base(name, anualIncome)
        {
            AnualIncome = anualIncome;
            EmployeeQuantity = employeeQuantity;
        }

        //método para calcular quanto de imposto a pessoa juridica irá pargar
        internal override double TaxCalc()
        {
            double TotalTaxPaid;
            if (EmployeeQuantity < 10)
            {
                TotalTaxPaid = AnualIncome * 0.16;
            }
            else
            {
                TotalTaxPaid = AnualIncome * 0.14;
            }

            return TotalTaxPaid;
        }
    }
}
