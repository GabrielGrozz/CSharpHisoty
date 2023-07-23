//Hashset seria outra forma de armazernarmos valores, segue a mesmo sintaxe do List, porém ele não aceita armazenar valores repetidos e os valores armazenador não possuem uma posição
//por não possuir possições não é possível fazer um laço for nele, mas podemos utilizar o foreach

HashSet<string> values = new HashSet<string>();

values.Add("gabriel");
values.Add("davi");
//mesmo passando para adicioanr dois leo, só será adicionado um
values.Add("leo");
values.Add("rtx4090");
values.Add("leo");
values.Add("controle8bitdo");


    //podemos verificar se existe um elemento dentro dele atravez do contains, que irá nos retornar um booleano
    Console.WriteLine(values.Contains("garrafaPET"));
    Console.WriteLine(values.Contains("gabriel"));

foreach (var value in values) { 

    Console.WriteLine(value);
}
