//temos o bloco using para nos auxiliar quando formos utilizar  objetos IDisposable( no caso objetos que não são gerenciador pelo maquina virtualdo/clr C#), ele irá fechar automa-
//ticamente esses objetos quando a execução for finalizada (temos o filestream, streamreader como exemplo de objetos IDisposable)

//com o using precisamos passar como argumento oque iremos utilizar, aqui no caso será o FileStream, assim que a execução parar o objeto será automaticamente fechado.
try
{
    // ------   PODEMOS FAZER DESSA FORMA QUE IRÁ FUNCINAR, PORÉM É UMA FORMA MAIS EXTENSA DE SE ESCREVER

    //using (FileStream fs = new FileStream(@"C:\Users\gabri\OneDrive\Documentos\arquivos\text.txt", FileMode.Open, FileAccess.ReadWrite))
    //{
    //    using (StreamReader sr = new StreamReader(fs))
    //    {
    //        string line = sr.ReadLine();
    //        Console.WriteLine(line);
    //    }
    //}

    // ------ POR OUTRO LADO TEMOS ESSE MODO QUE SERÁ UMA SINTAXE MAIS RESUMIDAFile.OpenRead(@"C:\Users\gabri\OneDrive\Documentos\arquivos\text.txt

    using (StreamReader sr = new StreamReader(new FileStream(@"C:\Users\gabri\OneDrive\Documentos\arquivos\text.txt", FileMode.Open, FileAccess.ReadWrite)))
    {
        string line = sr.ReadLine();
        Console.WriteLine(line);
    }
}
catch (IOException e)
{
    Console.WriteLine("[ERROR] " + e.Message);
}