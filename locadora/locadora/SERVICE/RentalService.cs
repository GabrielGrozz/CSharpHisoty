using locadora.ENTITIES;
using System;
namespace locadora.SERVICE
{
    internal class RentalService
    {
        public double PricePerHour { get; set; }
        public double PricePerDay { get; set; }

        private BrazilTaxService _brazilTaxService = new BrazilTaxService();
        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            //isso irá nos retornar o total de horas em que o veículo foi usado
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0;

            if (duration.TotalHours <= 12)
            {
                //se ele ficar alugado por menos de doze horas será cobrado o preço por hora arredondado para cima
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                //se ele ficar alugado por mais de doze horas será cobrado o preço por dia arredondado para cima
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalHours);
            }

            //calculando o imposto
            double tax = _brazilTaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);

      
        }
    }
}
