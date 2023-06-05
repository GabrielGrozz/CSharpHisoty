Console.WriteLine("digite a hora que o jogo começou e acabou:");
string[] hora = Console.ReadLine().Split(' ');
int inicio = int.Parse(hora[0]);
int final = int.Parse(hora[1]);

int duracao;

if (inicio < final)
{
    duracao = -(inicio - final);
}
else
{
    duracao = 24 - inicio + final;
}
Console.WriteLine($"O jogo durou {duracao} horas");