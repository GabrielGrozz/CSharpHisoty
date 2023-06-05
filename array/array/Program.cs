/*
 * int n = int.Parse(Console.ReadLine());

//instanciado o double[] para que fique reservado um local na memoria para o nosso vetor
double[] years = new double[n];


//usamos um for para atribuirmos os valores dentro do array
for (int i = 0; i < years.Length; i++)
{
    years[i] = double.Parse(Console.ReadLine());
}

double everage = 0.0;
for (int i = 0;i < years.Length; i++)
{
    everage += years[i];
}

double media = everage / years.Length;

Console.WriteLine(media);
*/
//acima temos um exemplo utilizando um modelo structure

//agora teremos um exemplo com classes

using array;

int quanty = int.Parse(Console.ReadLine());

//quando formos usar um array de classe, devemos passar a classe como o tipo
Product[] vetor = new Product[quanty];
for (int i = 0; i < quanty; i++)
{
    string name = Console.ReadLine();
    double price = double.Parse(Console.ReadLine());


    //após pegarmos os valores que irão ficar no nosso objeto, devemos instanciar um novo objeto na posição onde ela irá ficar dentro do array, e assim passar o nome e preço para a nossa classe Product
    vetor[i] = new Product { Name = name, Price = price };
}


double media = 0.0;

for (int i = 0; i < quanty; i++)
{
    //podemos acessar a posição que queremos dentro do array passando o seu index
    //aqui como queremos o Price da primeira posição do array, passamos o array[possição dele].oque queremos
    media += vetor[i].Price;
}

double avg = media / quanty;

Console.WriteLine(avg);


