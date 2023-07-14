namespace EmpressProject.SERVICES
{
    internal class PaypalTax : ITaxService
    {
        public double tax(double amount)
        {
            return 10;  
        }
    }
}
