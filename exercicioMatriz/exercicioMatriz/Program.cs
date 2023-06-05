
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva o tamanho que será a nossa matriz: ");
            int value = int.Parse(Console.ReadLine());

            int[,] minhaMatriz = new int[value, value];


            //iremos utilizar dois for para acrrescentarmos os valores na matriz
            //esse primeiro será para escolhermos qual das linhas será adicionado
            for (int i = 0; i < value; i++)
            {
                Console.WriteLine($"Digite os {value} valores da linha {i + 1} da matriz:");
                string[] valuesLine = Console.ReadLine().Split(' ');

                //nesse segundo for será onde iremos adicionar os valores dentro da linhas, esse f  será executado até o final
                for (int j = 0; j < value; j++)
                {
                    minhaMatriz[i, j] = int.Parse(valuesLine[j]);
                }
            }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < value; i++)
            {
                Console.WriteLine(minhaMatriz[i, i]);
            }

            //para percorrermos uma matriz, geralmente sempre iremos utilizar dois laços de repetição, um para linha e outro para coluna
            int count = 0;
            for (int i = 0;i < value; i++)
            {
                for (int j = 0;j < value; j++)
                {
                    if (minhaMatriz[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Quantidade de negativos: " + count);



        }
    }
}