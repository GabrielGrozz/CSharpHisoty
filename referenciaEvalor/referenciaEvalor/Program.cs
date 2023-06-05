using referenciaEvalor;

//                      REFERENCIA
//quando iniciamos uma classe utilizando o new, estamos referenciando ela

//nesse exemplo, o numbers irá fazer uma referencia ao Value, que esta em outro lugar da memoria
//o number está na stack, fazendo uma referencia ao Value, que esta no heap, por isso o numbers se encaixa como uma variavel ponteiro
Value numbers1 = new Value();

//neste exemplo, numbers1 e numbers2 estão apontando para a mesma classe/variavel, que seria o Values, pois quando passamos o numbers1 para o numbers2, passamos apenas a referencia
//de onde a classe está, assim as duas irão apontar para o mesmo local
Value number2 = numbers1;

//                             STRUCTS
//diferente da referencia, o struct trabalha com um esquema de "caixas", diferentemente dos ponteiros da referencia
double x, y;

x = 10;

y = x;
//struct nada mais é doque os valores que ja usamos, int,double,char,string...

//no exemplo acima, como sao variaveis de struct, elas não apontam para nenhum local na memoria, e sim simplemente setam seus valores na stack
//sendo assim, o "y" é uma cópia de x.

//quando instanciamos um struct, os valores dele vem como null, assim sendo necessário setalos
//e ela está na stack, assim sendo individual
Value v;
v.v1 = 5;
v.v2 = 10;

Console.WriteLine(v);

//ja na classe não, pois ao instancialo com o new, ele logo atribui os valores padroes de inicialização
//com o new, a classe irá ficar no heap, assim sendo a variavel vA, uma variavel de ponteiro
Value vA = new Value();
Console.WriteLine(vA);


