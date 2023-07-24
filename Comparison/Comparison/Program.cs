using Comparison.Entities;

List<Product> products = new List<Product>();

Product product1 = new Product() { Name = "maça", Value = 2.50 };
Product product2 = new Product() { Name = "pera", Value = 4.10 };
Product product3 = new Product() { Name = "mamao", Value = 7.90 };
Product product4 = new Product() { Name = "abacate", Value = 12.00 };
products.Add(product1);
products.Add(product2);
products.Add(product3);
products.Add(product4);

//podemos mudar o critério de comparação sem mechermos na classe Product, abaixo segue os exemplos

//aqui no nosso sort passamos uma referencia de uma função, no caso, isso seria um delegate
//delegate é basicamente uma referencia para uma funcao com type safety.
//products.Sort(CompareProduct);

//podemos também usar uma expressão lambda, que seria uma callback do js
//não precisamo passar o tipo dos parametro, pois eles ja são passados implicitamente
products.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));

foreach (Product product in products) Console.WriteLine(product.Name + " " + product.Value);


//podemos utilizar uma função delegate para ordenarmos a nossa lista
static int CompareProduct(Product product1, Product product2)
{
    return product1.Name.CompareTo(product2.Name);
}
