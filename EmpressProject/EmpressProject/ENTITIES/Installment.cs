namespace EmpressProject.ENTITIES
{
    internal class Installment
    {
        public int DueDate { get; set; }
        public double Amount { get; set; }

        public Installment()
        {
            DueDate = 1;
            Amount = 120;
        }
    }
}
