using LerArquivos.ENTITIES;

//caminho dos arquivos
string Sourcepath = @"C:\Riot Games\arquivos\arquivoDeEntrada.csv";
string Outpath = @"C:\Riot Games\arquivos\arquivoDeSaida.csv";

try
{

    //array para as linhas de dados pego no sourcePath
    string[] informacoes = File.ReadAllLines(Sourcepath);

    //laço baseado no tamanho do array dos dados
    for (int i = 0; i < informacoes.Length; i++)
    {

        //array que irá conter os dados de cada linha separadamente(separados por ,)
        string[] data = informacoes[i].Split(',');

        //variaveis com os valores do arquivo
        string nome = data[0];
        double valor = double.Parse(data[10]);
        int quantidade = int.Parse(data[2]);

        //classe instanciada com os dados do arquivo
        Person pessoa = new Person(nome, valor, quantidade);

        //escrevendo os dados em um novo arquivo
        using (StreamWriter escritor = File.AppendText(Outpath))
        {
            escritor.WriteLine($"{pessoa.Name},{pessoa.Total()}");
        }


    }
}
catch(IOException e)
{
    Console.WriteLine("[IO EXCEPTION] -- " + e.Message);
    Console.WriteLine("------------------------------------------");
}
catch(Exception e)
{
    Console.WriteLine("[GENERIC EXCEPTION] -- " + e.Message);
    Console.WriteLine("------------------------------------------");
}

