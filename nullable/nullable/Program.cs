//não podemos definir o valor null para uma variavel comum, para isso devemos utilizar o ?

//int valor = null;

//com o ? podemos definir uma variavel como nulla, ou poder receber um valor nullo

int? a = null;
int? b = 5;

//caso queiramos exibir algo nulo, ele simplesmente não irá aparecer
Console.WriteLine(a);
Console.WriteLine(b);

//o HasValue irá verificar se há um valor nulo ou não
Console.WriteLine(a.HasValue);
Console.WriteLine(b.HasValue);

//o GetValueOfDefault irá nos retornar o valor que está na variavel, caso ela não possuo ou seja nulo, retornará o valor default do tipo
Console.WriteLine(a.GetValueOrDefault());
Console.WriteLine(b.GetValueOrDefault());

//caso Queiramos usar o Value para ver o valor das variaveis, e ela for nula, isso resultará em um erro
Console.WriteLine(a.Value);
Console.WriteLine(b.Value);

//caso queiramos atribuir uma variavel que pode ser null em outra variavel, usamos o operador de coalescensia nula

double? x = null;
//isso basicamente estará checando que, caso x possua um valor diferente de null, y irá receber esse valor, mas caso x seja null, y irá receber o valor mostrado após as ??, que é 0
double? y = x ?? 0;