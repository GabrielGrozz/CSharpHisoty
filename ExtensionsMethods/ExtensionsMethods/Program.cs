using ExtensionsMethods.Extensions;

//nesse projeto iremos tratar sobre extensions methods, que seriam métodos que iremos criar.

//nesse exemplo iremos utilizar um Date Time

DateTime data = new DateTime(2023, 07, 21, 09, 30, 00);

//podemos chamar o método que criamos 
Console.WriteLine(data.TimeSpace());

//aqui usamos outro método de extensão
string phrase = "Hoje eu acordei e fiz café";
Console.WriteLine(phrase.StringSize(15));
