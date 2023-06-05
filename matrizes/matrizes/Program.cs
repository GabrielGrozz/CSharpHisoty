//matrizes são como as listas ou os array, pórem são bidimernsionais, sendo compostas por linhas e colunas

//essa é a declaração de uma matriz, ela por sua vez tem tamanho fixo, sendo passado primeiro o numero de linhas e depois o numero de colunas
double[,] myMatriz = new double[2,3];

//o .Rank mostra a quantidade de linha que há na matriz
Console.WriteLine(myMatriz.Rank);

// o .lenght mostra o total de "células" que a matriz possui
Console.WriteLine(myMatriz.Length);

//com o .GetLenght podemos saber a quantidade de linhas e colunas, basta passarmos por paramentros, caso passemos 0 ele irá retornar a quantidade de linhas, e caso passemos 1 ele irá retornar a quantidade de colunas
Console.WriteLine(myMatriz.GetLength(1));