namespace GEnerics2.Entities
{
    internal class Product : IComparable
    {
        public string Name { get; set; }
        public double Value { get; set; }

        public Product(string name, double value)
        {
            Name = name;
            Value = value;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Product)) throw new ArgumentException("object is not a Product type");

            //fazendo o processo de downcast
            Product other = obj as Product;

            return Value.CompareTo(other.Value);
        }
    }
}
