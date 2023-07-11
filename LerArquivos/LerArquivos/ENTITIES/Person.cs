//classe comum
namespace LerArquivos.ENTITIES
{
    internal class Person
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public int Quantity { get; set; }

        public Person(string name, double value, int quantity)
        {
            Name = name;
            Value = value;
            Quantity = quantity;
        }

        public double Total() { return Value * Quantity; }
    }
}
