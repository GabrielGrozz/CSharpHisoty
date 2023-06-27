using System.Globalization;
namespace exercicio_heranca_e_polimorfismo
{
    internal sealed class UsedProduct : Product
    {
        internal DateTime ManufactureDate { get; set; }

        internal UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        internal override string PriceTag()
        {
            return $"{Name} (used) ${Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufactured date: {ManufactureDate.ToShortDateString()})";
        }
    }
}
