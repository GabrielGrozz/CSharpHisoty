namespace EmpressProject.SERVICES
{
    internal class PaypalTax : ITaxService
    {
        public double tax(double amount, int quantity)
        {
            return 10;  
        }
    }
}
