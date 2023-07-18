
// ---------------- SE FIZERMOS DESSE JEITO TEREMOS UM PROBLEMA DE REUSO POR CAUSA QUE SÓ IREMOS ACEITAR VALORES DO TIPO INT
// ---------------- ISSO SERIA UM PROBLEMA CASO QUEIRAMOS USAR NOMES POR EXEMPLO, POR ISSO IREMOS UTILIZAR O GENERICS

// ---------------- PODERIAMO UTILIZAR ELE COM VAR OU OBJECT, MAS TERIAMO UM PROBLEMAS DE TYPE SAFETY

//using Generics.ENTITIES;

//Console.Write("How many values? ");

//GenericClass classeGenerica = new GenericClass();

//int quantity = int.Parse(Console.ReadLine());

//for (int i = 0; i < quantity; i++)
//{
//    classeGenerica.AddValue(int.Parse(Console.ReadLine()));
//}

//classeGenerica.Print();
//Console.WriteLine("First: " + classeGenerica.First());


// -------- USANDO O TIPO GENERIC

using Generics.ENTITIES;

Console.Write("How many values? ");

//quando usamos um tipo Generic na classe precisamos informas qual será o tipo de valor que será usado/armazenado
//precisamo passar tanto no tipo e na instanciação
GenericClass<string> classeGenerica = new GenericClass<string>();

int quantity = int.Parse(Console.ReadLine());

for (int i = 0; i < quantity; i++)
{
    //caso fosse uma valor do tipo int,double,float... iriamos precisar fazer um Parse
    classeGenerica.AddValue((Console.ReadLine()));
}

classeGenerica.Print();
Console.WriteLine("First: " + classeGenerica.First());

