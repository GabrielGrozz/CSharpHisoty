//Object streamwriter é autoexplicativo, serve para escrever em documento, é necessário instancialo passando o filestream como argumento

//esse será o caminho do arquivo utilizado
string path = @"C:\Users\gabri\OneDrive\Documentos\arquivos\text.txt";

try
{
    //podemos usar o bloco using qunado formos utilizar o FileInfo, pois ele é instanciado, quando utilizarmos somente o File, não é necessáio fechar o arquivo após a execução
    //using (StreamWriter streamWriter = new StreamWriter(new FileStream(path, FileMode.Append, FileAccess.Write)))

    //dessa forma podemos armazenar cada linha em um index do array
    string[] lines = File.ReadAllLines(path);


    //quanto desse jeito
    using (StreamWriter streamWriter = File.AppendText(path))
    {
        foreach (string line in lines)
        {
            streamWriter.WriteLine(line.ToUpper());
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("[ERROR] -- " + e.Message);
}