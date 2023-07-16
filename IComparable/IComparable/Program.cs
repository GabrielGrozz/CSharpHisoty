
using IComparadbleClass;

string path = @"D:\dev\C#\CSharpHisoty\source.csv";

try
{
    //usamos um filereader para lermos o arquivo
    using (StreamReader fs = File.OpenText(path))
    {
        ////criamos uma lista de strings para armarzenarmos os dados do arquivo
        //List<string> list = new List<string>();

        ////whilhe para enquando o fs.endofstream não chegar ao fim continuar rodando
        //while (!fs.EndOfStream)
        //{
        //    list.Add(fs.ReadLine());
        //}
        ////o .sort irá ordenar a nossa list se baseando na ordem alfabética
        //list.Sort();
        ////percorrer a lista e logala
        //foreach (string line in list)
        //{
        //    Console.WriteLine(line);
    }

    //mas e se nós quisermos ordenar uma lista que tiver mais valores?
    //caso a gente tente fazer dessa forma irá nos retornar uma excessão, pois iremos precisar dizer por qual valor o .sort irá se basear
    //iremos utilizar uma classe para isso

    List<Employee> list = new List<Employee>();


    using (StreamReader sr = File.OpenText(path))
    {

        // CONFERIR A CLASSE


        while (!sr.EndOfStream)
        {
            list.Add(new Employee(sr.ReadLine()));
        }
        list.Sort();

        foreach (Employee e in list)
        {
            Console.WriteLine(e);
        }
    }



}
catch (IOException e)
{
    Console.WriteLine("IO EXPECTION ");
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine("EXPECTION ");
    Console.WriteLine(e.Message);
}