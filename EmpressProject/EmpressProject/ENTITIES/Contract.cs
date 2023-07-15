namespace EmpressProject.ENTITIES
{
    internal class Contract
    {
        //classe do contrato com seu número, data, valor e parcelas
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

        public List<Installment> Installments = new List<Installment>();

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;

        }

    }
}
