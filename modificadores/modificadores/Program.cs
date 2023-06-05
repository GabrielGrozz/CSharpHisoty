using modificadores;

//sem o ref
int x = 10;

Calculator.editNum(x);

Console.WriteLine(x);


//          MODIFICADOR DE PARAMETRO REF
//com o ref, podemos alterar as variaveis que utilizamos como parametro nas funcoes com a palavras ref
//o ref deve estar presente na declaracao do método e na chamada dele

Calculator.editNumber(ref x);
//agora o valor x será alterado
Console.WriteLine(x);