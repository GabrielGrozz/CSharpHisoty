//podemos mecher com pastas utilizando o Directory ou DirectoryInfo, funcionam da mesmoa forma que o File e FileInfo

string path = @"C:\Program Files\Adobe\Acrobat DC";

//para pastas
//o directory cria uma coleção de dados, com isso nã o é possível instanciar ele com uma list o o próprio directory mas sim em uma IEnumerable
//                                                      //aqui passamos o caminho, a pattern dos diretorios que queremos e a opção de busca
//IEnumerable<string> dir = Directory.EnumerateDirectories(path, "*.*", SearchOption.TopDirectoryOnly);

//foreach (string dirEntry in dir)
//{
//    Console.WriteLine(dirEntry);
//}

// para arquivos
IEnumerable<string> dir = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

    double asi = 0;
foreach (string dirEntry in dir)
{
    asi += 1;
    Console.WriteLine(dirEntry);
}
    Console.WriteLine(asi);

