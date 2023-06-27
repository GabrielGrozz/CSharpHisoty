using System.Globalization;
namespace exercicio_heranca_e_polimorfismo
{
    internal sealed class ImportedProduct : Product
    {
        internal double CustomFee { get; set; }

        internal ImportedProduct(string? productName) { }
        internal ImportedProduct(string name, double price, double customFee) : base(name, price)
        {
            CustomFee = customFee;
        }


        internal override string PriceTag()
        {
            return $"{Name} ${TotalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Customs fee: ${CustomFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }

        internal double TotalPrice()
        {
            return Price + CustomFee;
        }
    }
}
