//diferente do hashset, o sortedset é organizado

SortedSet<int> a = new SortedSet<int>() { 41, 451, 784, 5154, 165, 417, 54, 132, 156 };
SortedSet<int> b = new SortedSet<int>() { 41, 451, 784, 4, 1, 89, 6, 2, 7, 75 };

//podemos instanciar um sortedset com dados de outo sortedset
SortedSet<int> c = new SortedSet<int>(a);

//podemos unir dos sortedset, mas os valores que se repetem não irão ser adicionados
c.UnionWith(b);

//podemos pegar a intercequeção dos dois conjuntos, ou seja, os numeros que se repetem
SortedSet<int> d = new SortedSet<int>(a);
d.IntersectWith(c); 

//podemos criar um sorted com os valores, menos os valores de outro passado
SortedSet<int> e = new SortedSet<int>(a);
e.ExceptWith(b);





