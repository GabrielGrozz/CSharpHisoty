namespace locadora.SERVICE
{
    internal class BrazilTaxService : ItaxService
    {
        //essa classe será dependente da ItaxService, logo os nome das variaveis devem bater

        //se o valor do aluguel for infeiror a 100, o imposto será 20%, caso seja maior que isso será 15%
        public double Tax(double amount)
        {
            if (amount < 100.00)
            {
                //retorna o valor que será pago de imposto
                return amount * 0.20;
            }
            else
            {
                //retorna o valor que será pago de imposto
                return amount * 0.15;
            }
        }
    }
}
