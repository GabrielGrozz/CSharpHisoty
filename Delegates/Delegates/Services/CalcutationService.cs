namespace Delegates.Services
{
    internal class CalcutationService
    {
        public static double Max(double v1, double v2)
        {
            return (v1 > v2) ? v1 : v2;
        }

        public static double Soma(double v1, double v2)
        {
            return v1 + v2;
        }

        public static double Multi(double v1, double v2)
        {
            return v1 * v2;
        }

        public static double Square(double v1)
        {
            return v1 * v1;
        }
    }
}
