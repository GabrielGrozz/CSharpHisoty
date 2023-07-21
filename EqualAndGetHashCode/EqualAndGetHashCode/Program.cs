//Equal irá nos retornar booleano caso dois elementos sejam igual

//retornar true pois são dois elementos igual
using EqualAndGetHashCode;

Console.WriteLine(("abc").Equals("abc"));

//retorna false pois se tratam de strigs diferentes
Console.WriteLine(("abc").Equals("123 "));

//por outro lado temos o GetHashCode, cada elemento terá um valor que ele irá calcular com uma lógica própria
//caso dois elementos sejão iguais, eles possuiram o mesmo valor, senso assim iguais, porém há a chance de que dois
//elementos diferente sorteiem o mesmo valor

string a = "gabriel";
Console.WriteLine(a.GetHashCode());
Console.WriteLine(a.GetHashCode());

string b = "grozz";
Console.WriteLine(b.GetHashCode());

//tipos pré definidos como string,int, double ja possuem os dois métodos implementados, porém caso queiramo usalos em
//uma classe/struct/constructor, é necessário que os criemos de forma persoanlizadas

// o GetHashCode é mais rápido que o Equals, por isso é aconselhavel usalo para trabalhos maiores

Product produto1 = new Product() { Name = "groizz", value = 1500.00 };
Product produto2 = new Product() { Name = "groizz", value = 56468.00 };

//mesmo a classes sendo diferente, ela irá retornar true, pois estamos nos baseando pelo Name da classe
Console.WriteLine(produto1.Equals(produto2));
