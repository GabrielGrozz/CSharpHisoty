using System.Xml.Schema;

namespace FileProject.ENTITIES
{
    internal class Order
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public int Quantity { get; set; }

        public Order() { }
        public Order(string name, double value, int quantity)
        {
            Name = name;
            Value = value;
            Quantity = quantity;
        }

        public double TotalValue()
        {
            return Value * Quantity;
        }
    }
}
