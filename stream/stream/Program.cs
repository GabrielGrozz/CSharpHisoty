using System.Text;

string path = @"C:\Users\gabri\OneDrive\Documentos\arquivos\text.txt";
FileStream fs = null;
StreamReader sr = null;

//(a stream seria uma sequencia de dados que estão sendo passados)
//o filestream é uma classe que nos permite escrever e ler arquivos de texto
//precisamos instanciar o filestream de modo que ele fique associado a um arquivo
//o filestream irá criar um arquivo escrito em binário, dai vamos precisar "traduzir" esse binário, passa isso utilizamos o streamreader, que como o nome diz, lê stream

//temos varias formar de instanciar o filestream

//nessa forma passamos o caminho, o modo que iremos utilizar o fs e por fim os tipos de acesso que ele irá ter
fs = new FileStream(path, FileMode.Append, FileAccess.Write);

//caso queiramos escrever algo no final do arquivo vamos precisar de um array em byte com oque iremos querer escrever
byte[] text = Encoding.UTF8.GetBytes("texto traduzido");
//aqui passamos o array que será escrito, o index de começo e fim
fs.Write(text, 0,text.Length);

//podemos fazer varias coisas com o filemode, podemos usar o append para abrirmos o arquivo e inserirmos algo no final dele
//                                            podemos recriar o arquivo com o create
//                                            ou simplesmente abrir o arquivo com o open


//com isso teremos um arquivo traduzido do binário

// --AQUI SERIA USADO CASO QUISSESEMOS LER O ARQUIVO--"
//sr = new StreamReader(fs);
//string line = sr.ReadLine();
//Console.WriteLine(line);

//com isso após fazermos tudo oque queriamos com o arquivo, precisamo fecha-lo com o close
//o sr e o fs estão "conversando" diretamente com o SO sem passar pelo clr, com isso é necessário que fechemos os arquivos manualmente
fs.Close();

