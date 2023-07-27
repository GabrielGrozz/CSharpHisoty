using Consulta1.Entities;

Category c1 = new Category(1, "Tools", 2);
Category c2 = new Category(2, "Computers", 1);
Category c3 = new Category(3, "Eletronics", 1);

//nosso data source
List<Product> products = new List<Product>()
{
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, ProductCategory = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, ProductCategory = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, ProductCategory = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, ProductCategory = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, ProductCategory = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, ProductCategory = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, ProductCategory = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, ProductCategory = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, ProductCategory = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, ProductCategory = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, ProductCategory = c1 }
};

//nossa query
IEnumerable<Product> list1 = products.Where(x => x.ProductCategory.Tier == 1 && x.Price < 900); 

//execução da query
foreach (Product product in list1)
{
    Console.WriteLine($"{product.Id} - {product.Name} - {product.Price}");
}

Console.WriteLine(' ');
Console.WriteLine(' ');


//filtrado por categoria
//                               aqui ele irá pegar os itens de categoria Tools      e aqui ele vai pegar o nome dos itens filtrados
IEnumerable<string> list2 = products.Where(x => x.ProductCategory.Name == "Tools").Select(x => x.Name);

foreach (string product in list2)
{
    Console.WriteLine(product);
}

Console.WriteLine(' ');
Console.WriteLine(' ');

//que começa com a letra P - quando pegar um objeto e não quisermos toda as informações que nele contem, podemos fa zer um objeto anonimo
//                           nele podemos colocar apenas os valores que quisermos
var list3 = products.Where(x => x.Name[0] == 'C').Select(x => new { x.Name, categoryname = x.ProductCategory.Name });
/*                                                          aqui nós temos um ambiguidade, nós não podemos ter dois Name
 *                                                          para isso precisamo criar um apelido para o atributo
 */                                                          


foreach (var product in list3)
{
    Console.WriteLine("nome começa com C - " + product);
}

Console.WriteLine(' ');
Console.WriteLine(' ');

//aqui iremos pegar todos do tier e ordenar ela pelo preço, e caso não seja sulficiente, será ordenado por nome
var list4 = products.Where(x => x.ProductCategory.Tier == 1).OrderBy(x => x.Price).ThenBy(x => x.Name);

foreach(var product in list4)
{
    Console.WriteLine($"{product.Id} - {product.Name} - {product.Price}");
}
