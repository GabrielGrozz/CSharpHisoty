
using Action.Entities;

List<Product> list = new List<Product>();


list.Add(new Product("tv", 3620.00));
list.Add(new Product("pc", 4500.00));
list.Add(new Product("sofa", 320.00));
list.Add(new Product("cama", 500.00));

//delegate que podemos utilizar caso o método esteja em outro lugar
Action<Product> acao = UpdatePrice;

//podemos utilizar o delegate Action para quando quisermos utilizar alguma lógica opu ação
//um exempllo de onde podemos utilizada é no ForEach, que podemos passar uma Action/expressãoLambda


//list.ForEach(UpdatePrice);
//list.ForEach(p => { p.Value += p.Value * 0.1; });
list.ForEach(acao);



foreach (var item in list)
{
    Console.WriteLine(item.Value);
}

static void UpdatePrice(Product product)
{
    product.Value += product.Value * 0.1;
}