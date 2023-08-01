using fixaxao_linq.Entities;

//passamos o caminho do arquivo que iremos ler
Console.Write("Enter the full path of the csv: ");
string path = Console.ReadLine();

//lista para os produtos
List<Product> products = new List<Product>();

try
{
    //usamos o streamReader para ler o arquivo
    using (StreamReader streamReader = File.OpenText(path))
    {
        //lemos cada linha e criamos um product baseado nela
        while (!streamReader.EndOfStream)
        {
            string[] data = streamReader.ReadLine().Split(',');
            string productName = data[0];
            double productPrice = double.Parse(data[1]);

            products.Add(new Product(productName, productPrice));
        }
    }

    //aqui pegamos o preço de cada product
    IEnumerable<double> productsPrice = products.Select(x => x.Price);

    //tiramos a média de todos os preços
    double average = productsPrice.DefaultIfEmpty(0.0).Average();

    Console.WriteLine(' ');
    Console.WriteLine("Average: " + average);
    Console.WriteLine(' ');

    //criamos uma coleção com todos os preços que forem abaixo da média e o convertemos para lista
    List<string> underAverage = products.Where(x => x.Price < average).OrderByDescending(x => x.Name).Select(x => x.Name).ToList();

    //logamos esses preços
    foreach (string product in underAverage) 
    {
        Console.WriteLine(product);
    }

    

}
catch (Exception e)
{
    Console.WriteLine("[EXCEPTION] - " + e.Message);
}
