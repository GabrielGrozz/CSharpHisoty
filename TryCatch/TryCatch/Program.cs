//TRY-CATCH
// com o bloco try podemos executar blocos de código expecificos onde podem ocorrer excessões(erros), com isso poderemos utilizar o catch
try
{
    int value1 = int.Parse(Console.ReadLine());
    int value2 = int.Parse(Console.ReadLine());
    Console.WriteLine(value1 / value2);

}
//o bloco catch serve pra capturarmos essa exception que ocorreu e trata-la, seja mandando uma mensagem específica ou simplesmente a mensagem da exception

//quando um número é dividido por zero
catch (DivideByZeroException)
{
    Console.WriteLine("ERROR!!!!, YOU CANNOT DIVIDE SOMETHING BY 0");
}//essa exception que passamos é a mais genérica, sendo assim ela irá aceitar todas as excessões, para melhores tratamentos é melhor passarmos o tipo expecífico da exception
catch (Exception exeption)
{
    Console.WriteLine("ERROR ! " + exeption.Message);
}
//na tela de log poderemos ver todo as chamadas que aquela função teve que fazer para chegar a aquele determinado resultado