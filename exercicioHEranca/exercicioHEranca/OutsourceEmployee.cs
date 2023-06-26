namespace exercicioHEranca
{
    //utilizando o fundamento de sealed na classe
    internal sealed class OutsourceEmployee : Employee
    {
        double AdditionalCharge;

        public OutsourceEmployee() { }

        //reutilizando o construtor da superclasse com o base
        public OutsourceEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        //utilizando o fundamento do override no método payment com sealed
        public sealed override double Payment()
        {
            double basePayment = base.Payment();
            return basePayment + AdditionalCharge * 1.1;
        }

    }
}
