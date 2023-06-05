// O DateTimeKind é o tipo de formas que o horário pode ser armazenado, que seria em
//Local - horário em que a máquina está
// Utc- horário do gmt padrão
// Unspecified - quando não é informado

//********** BOA PRATICA*********
//uma boa prática é sempre armazenar horas em utc de forma em que irá ficar padrão
// e caso precisemos utiliza-lo de forma local, instanciaremos esse horario para mostra-lo no formato local


//*************************************

//myDate.ToLocalTime(); para transformar no horário local

// myDate.ToUniversalTime(); para transformar em Utc

//temos o Padrão ISo 8601, que é o padrão utilizado para armazenar a data

//o exemplo abaixo utilizada o ISO 8601
//que é ano,mes,dia, T de time, hora, minutos, segundo e o Z para definir ele como uma data utc padronizada
DateTime data = DateTime.Parse("2015-06-23T12:15:48Z");
Console.WriteLine(data);