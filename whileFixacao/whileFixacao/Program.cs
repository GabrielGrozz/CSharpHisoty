//setamos a variavel senha
int senha = 0;
Console.Write("digite a senha: ");

//caso a senha seja diferente de 2004, execute esse laço
while (senha != 2004)
{
    Console.WriteLine("senha invalida, digite novamente");
    senha = int.Parse(Console.ReadLine());
    
}

Console.WriteLine("ACESSO PERMITIDO");