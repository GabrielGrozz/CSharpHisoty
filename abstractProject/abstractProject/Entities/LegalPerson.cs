namespace AbstractProject.Entities
{
    internal class LegalPerson : PersonShape
    {
        internal string Name { get; set; }
        internal double AnualIncome { get; set; }
        internal int EmployeeQuantity { get; set; }

        //método para calcular quanto de imposto a pessoa juridica irá pargar
        internal override double TaxCalc()
        {
            double TotalTaxPaid;
            if (EmployeeQuantity > 10)
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
