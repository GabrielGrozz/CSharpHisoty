// esse projeto é exclusivo para fixacao, caso voce(eu) não lembre como usar algo, reveja a aula e tente aplicar aqui
// --------------se possível apagar o código após feito, pois ja temos os arquivos com essas bases salvos na pastas com os arquivos

// -------- FUNC

//É delegate, que diferente do action, retorna um valor, podemos utilizar expressões lambda nele tbm

using Action.Entities;

List<PrivateService> list = new List<PrivateService>();


list.Add(new PrivateService("tv", 3620.00));
list.Add(new PrivateService("pc", 4500.00));
list.Add(new PrivateService("sofa", 320.00));
list.Add(new PrivateService("cama", 500.00));

//essa será a declaração do Func, -- Func<a entrada no que iremos usar, no caso é uma função que tem como parametro a classe, então o in é a classe
//que estamos passando, no outro será o retorno do função, que no caso é um int>
Func<PrivateService, int> example = funcaoExemplo;

//podemos fazer também com uma lambda também
//aqui não é necessário expecificar o tipo de p, pois ele ja é informado implicitamente na declaração do Func
Func<PrivateService, int> exampleWithLambda = p => p.Name.Length; 

// o select é um método que recebe um Func, iremos utilizar ele como exemplo
// o select deve ser chamado a partir de um tipo(no nosso caso uma list) e irá retornar ela em outro tipo(no caso um IEnumerable)
//caso seja necessário que serja retornado outro tipo(como um List por exemplo) precisamos converter o select(caso seja uma list, use o .tolist)
IEnumerable<int> list2 = list.Select(exampleWithLambda); 

//assim temos um ienumerable com os valores que o nosso delegate retornou
foreach (int i in list2)
{
    Console.WriteLine(i);
}

//podemos chegar a conclusão que delegate serve para criarmos outras coleções.

static int funcaoExemplo(PrivateService p)
{
    return p.Name.Length;
}