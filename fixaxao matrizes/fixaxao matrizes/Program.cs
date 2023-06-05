namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho da matriz: ");
            string[] matrizSize = Console.ReadLine().Split(' ');
            int row = int.Parse(matrizSize[0]);
            int column = int.Parse(matrizSize[1]);

            int[,] matriz = new int[row, column];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Random rnd = new Random();
                    int columnValue = rnd.Next(50);
                    matriz[i, j] = columnValue;
                }
            }

            Console.WriteLine("Matriz do tamanho " + row + ", " + column + " gerada");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(matriz[i, j] + ", ");
                }
                Console.WriteLine();
            }

            Console.Write("Passe um número da matriz: ");
            string[] positions = Console.ReadLine().Split(' ');
            int position = int.Parse(positions[0]);






            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (matriz[i, j] == position)
                    {

                        if (j > 0)
                        {
                            Console.WriteLine("Left " + matriz[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + matriz[i - 1, j]);
                        }

                        if (j < column - 1)
                        {
                            Console.WriteLine("Right: " + matriz[i, j + 1]);
                        }

                        if (i < row - 1)
                        {
                            Console.WriteLine("Down: " + matriz[i + 1, j]);
                        }

                    }
                }






            }
        }
    }
}