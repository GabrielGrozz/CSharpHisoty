using Func.Entities;

List<Product> list = new List<Product>();


list.Add(new Product("tv", 3620.00));
list.Add(new Product("pc", 4500.00));
list.Add(new Product("sofa", 320.00));
list.Add(new Product("cama", 500.00));

//para declararmos um delegate Func primeiro usamos a palavra Func, entre < colocar oque iremo usar de entrada, e oque irá sair>
//aqui no exeplo, passamos ele com uma uma função que a entrada dela é um parametro do tipo Product e que retorna uma string
Func<Product, string> upped = grande;

//podemos também usar uma expressão lambda 
//Func<Product, string> upped = p => p.Name.ToUpper();


// Select recebe um delegate Func por exemplo
List<string> list2 = list.Select(upped).ToList();



//aqui o nosso foreach será de string, pois estamos usando o list2, que é uma lista de nome em caixa alta
foreach (string item in list2)
{
    Console.WriteLine(item);
}

static string grande(Product product)
{
    return product.Name.ToUpper();
}