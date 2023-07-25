namespace Predicate.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        //podemos utilizar no lugar da expressao lambda que passamos um predicate, que é basicamente um delegate
        public static bool ProductTest(Product product)
        {
            return product.Price > 370.00;
        }
    }

}
