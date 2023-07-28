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
//podemos filtar por valores, seja ele o maior valor ou o menor valor
//caso chamemos o Max sem argumentos, é necessário que na classe tenha um IComparable
var value1 = products.Max(x => x.Price);
var value2 = products.Min(x => x.Price);

Console.WriteLine(value1);
Console.WriteLine(value2);

Console.WriteLine(' ');

//podemos somar todos os valores
var value3 = products.Where(x => x.ProductCategory.Name == "Tools").Sum(x => x.Price);
Console.WriteLine(value3);

Console.WriteLine(' ');

//podemos também pegar a media de valores
var value4 = products.Average(x => x.Price);
Console.WriteLine(value4);

Console.WriteLine(' ');

//caso a gente tente tirar a média de alguma coleção vazia, isso irá nos retornar uma excessão, podemos trata isso da seguinte forma
var value5 = products.Where(x => x.ProductCategory.Tier == 5).Select(x => x.Price).DefaultIfEmpty(0.0).Average();
//              isso irá nos retornar uma coleção vazia      iremos selecionar o valor dessa coleção e definilo como 0 por padrao
Console.WriteLine(value5);

Console.WriteLine(' ');

