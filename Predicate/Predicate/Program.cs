using Predicate.Entities;

List<Product> products = new List<Product>();

products.Add(new Product("tv",3200.00));
products.Add(new Product("ps2",120.00));
products.Add(new Product("cadeira", 780.00));
products.Add(new Product("microondas", 350.00));

//o metodo removeall leva um predicate como argumento, mas podemos utilizar uma expressão lambda tbm
//aqui caso o valor do p seja maior que 370, isso irá retornar true, assim ele será removido da lista
//products.RemoveAll(p => p.Price < 370.00);

//foreach (Product p in products)
//{
//    Console.WriteLine(p.Name + " " + p.Price);
//}


//porém também podemos passar o predicate, ele funciona igual a um delegate

//no caso, a difença de um predicate pra um delegate é que um predicate irá retornar
//um booleano, diferente do delegate, que pode ter e ser de outros tipos além de conter parametro diferentes
products.RemoveAll(Product.ProductTest);

foreach (Product product in products)
{
    Console.WriteLine(product.Name + " " + product.Price);
}

