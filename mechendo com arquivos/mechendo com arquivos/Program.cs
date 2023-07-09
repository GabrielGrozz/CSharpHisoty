using System.IO;
//quando vamos mecher com arquivos podemos usar o file e o fileInfo. Os dois funcionam da mesma forma, porém o file é mais simples estatico, toda vez que formos utilizalo ele irá realizar
//uma verificacao de seguranca, oque pode deixar o nosso projeto mais lento

//ja o fileinfo é necessário instancialo, isso faz com que não seja necesário realizar a verificacao de seguranca toda vez que formos utilizalo, assim nosso
//projeto irá  ficar um pouco mais rapido, mas não irá fazer muita diferenca em projetos pequenos

//junto disso teremos a IOException que irá ser uzada para excessões que se tratem do namespace system.IO


//IREMOS UTILIZAR O FILEINFO QUE PRECISA SER INSTANCIADO, INSTANCIAMOS ELE PASSANDO O CAMINHO E O NOSSO DO ARQUIVO QUE IREMOS UTILIZAR

try
{
    //                            o @ serve para que não seja necessário colocar duas barras ( \\ ) quando passamos o caminho
    FileInfo fileinfo = new FileInfo(@"D:\dev\C#\CSharpHisoty\doc.txt");

    //podemos tanto colocar a url a mão como colocala atraves de uma variavel
    string targetpath = @"D:\dev\C#\CSharpHisoty\doc2.txt";
    //copyto irá apenas copiar o arquivo, precisamos passar o novo nome do arquivo na url
    fileinfo.CopyTo(targetpath);


    //aqui iremos utilizar o file apenas
    //como não estamos instanciando nada com um caminho devemos passar ele como argumento
    //readalllines irá ler todas as linhas do arquivo, com isso estamos armazenando cada linha em um array de strings
    string[] lines = File.ReadAllLines(@"D:\dev\C#\CSharpHisoty\doc.txt");
    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }

}
catch (IOException e)
{
    Console.WriteLine("ERROR!");
    Console.WriteLine(e.Message);
}
