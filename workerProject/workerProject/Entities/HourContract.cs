namespace workerProject.Entities
{
    internal class HourContract
    {
        //variavel que irá ficar a data do contrato
        public DateTime Date { get; set; }
        //valor ganho por hora
        public double ValuePerHour { get; set; }
        //horas
        public int Hours { get; set; }

        //construtor padrao
        public HourContract()
        {
        }

        //construtor com os três atributos
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        //método onde calcula o total ganho
        public double TotalValue()
        {
            double Total = ValuePerHour * Hours;
            return Total;

        }
    }
}
