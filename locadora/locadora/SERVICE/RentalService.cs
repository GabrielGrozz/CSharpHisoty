using locadora.ENTITIES;
using System;
namespace locadora.SERVICE
{
    internal class RentalService
    {
        public double PricePerHour { get; set; }
        public double PricePerDay { get; set; }

        //poderiamosusar essa forma para fazermos o imposto, ele funciona mas não é o ideal, o idela seria utilizarmos uma interface
        //desse modo que nós fizemos antes ele fica dependente do braziltexservice, mas caso precisemos utilizar outro imposto? teria que abrir essa classe e
        //modifica-la, oque é meio desgastante e nao reutilizavel, por isso usaremos interfaces, com as interfaces poderemos generalizar esse braziltexservice.
        //private BrazilTaxService _brazilTaxService = new BrazilTaxService();

        private ItaxService _taxService;
        public RentalService(double pricePerHour, double pricePerDay, ItaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
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
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            //calculando o imposto
            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);

      
        }
    }
}
