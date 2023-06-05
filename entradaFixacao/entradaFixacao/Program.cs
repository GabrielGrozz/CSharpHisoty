using System.Globalization;

Console.WriteLine("Digite seu nome:");
string name = Console.ReadLine();

Console.WriteLine("Digite quantos quartos há em sua casa:");
int rooms = int.Parse(Console.ReadLine());

Console.WriteLine("Coloque um número quebrado;");
//Como no português o separador é a virgula, é necessário utilizar uma virgula para que o número saia quebrado
//caso utilizado o ponto, o valor sairá como se fosse um inteiro, para isso, podemos apenas utilizar a virgula
//caso você que irá utilizar o ponto, é necessário passar o CultureInfo.InvariantCulture como segundo parâmetro
//para assim ele ignorar a questão da linguagem que está no computador.
float numBroken = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Seu último nome, idade e altura, na mesma linha:");
//é necessário colocar como que o array será divido atraves do Split
string[] info = Console.ReadLine().ToString(CultureInfo.InvariantCulture).Split(' ');

Console.WriteLine(name);
Console.WriteLine(rooms);
//Para que o valor apareça como um ponto e não virgula, utilizamos o CultureInfo.InvariantCulture aqui para ignorarmos a linguagem do computador
Console.WriteLine(numBroken.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(info[0]);
Console.WriteLine(int.Parse(info[1]));
//Quando o CultureInfo.InvariantCulture é aplicado na variável, ele altera na váriavel diretamente, agora quando -
//aplicaro no Console.WriteLine, ele alterá apenas na impressão do valor
double infoYear = double.Parse(info[2], CultureInfo.InvariantCulture);
Console.WriteLine(infoYear.ToString("F2", CultureInfo.InvariantCulture));





