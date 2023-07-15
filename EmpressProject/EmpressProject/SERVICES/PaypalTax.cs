namespace EmpressProject.SERVICES
{
    internal class PaypalTax : ITaxService
    {
        //é necessário fazer um for na hora de gerar o installments(parcelas)
        public double tax(double amount, int quantity)
        {
            double ValueWithTax = amount + (amount * 0.01 * (quantity + 1));
            double ValueWithPaymentTax = (ValueWithTax + (ValueWithTax * 0.02));

            return ValueWithPaymentTax += 0.002;
        }
    }
}
