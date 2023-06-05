using System.Linq;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> pessoas = new List<string>();

            //podemos adicionar pessoas na nossa lista utilizando o Add
            pessoas.Add("Gabriel");
            pessoas.Add("Jonas");
            pessoas.Add("Pietra");
            pessoas.Add("Nicoly");
            pessoas.Add("Pedro");
            foreach (string pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }

            //do jeito que fizemos acima, ele sempre irá adicionar um novo item no final da lista, porém com o Insert podemos escolher aonde iremos adicionar o novo item
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("------------------------------------------------");
            //adicionaremos rocket league na posição 2
            pessoas.Insert(2, "Rocket League");
            foreach (string pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("------------------------------------------------");

            //podemos também ver o tamanho da nossa lista atraves do count, que é uma forma diferente do array, onde utilizamos o lenght
            Console.WriteLine("tamanho: " + pessoas.Count());
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("------------------------------------------------");

            //podemos encrontrar um item pela sua primeira e ultima letra
            //para isso usamos o Find, que diferente dos outros anteriores, utiliza uma função de predicado como parametro(lambda), algo parecida com as callback de parametro do javascript
            //quando for 1 caracter, utilizar apenas aspas simples

            string pessoaComP = pessoas.Find(x => x[0] == 'P');// o "x" seria o item da lista, o [0] seria a posição da letra

            //Basicamente o Find irá procurarna nossa lista qual o primeiro item começa com P e retornar ele como true, esse que for true, irá entrar na variavel
            //o Find irá retornar a primeira pessoa que der True
            Console.WriteLine("primeiro com P: " + pessoaComP);

            //com o FindLast funciona da mesma forma, só que diferente, inves de pegarmos a primeira pessoa que começa com P, pegamos a ultima
            pessoaComP = pessoas.FindLast(x => x[0] ==  'P');
            Console.WriteLine("ultimo com P: " + pessoaComP);

            //com o FindIndex ele irá retornar o valor do index do item, no caso, qual dos items que começa com N, assim retornando o index dele
            int pos1 = pessoas.FindIndex(x => x[0] == 'N');
            Console.WriteLine(pos1);
            //e podemos procurar o ultimo que começa com N, utilizando o FindLastIndex

            //podemos criar outra lista a partir de uma lista
            //aqui no caso, será uma lista somente com pessoa que o nome começa com P
            List<string> semP = pessoas.FindAll(x => x[0] == 'P');
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("------------------------------------------------");

            //podemos remover dados diretamente da lista utilizando o Remove
            //caso tentemos remover algo que não exista, nada acontecerá
            pessoas.Remove("Jonas");

            //também podemos parametrar outras coisas, como as pessoa que começam com P
            pessoas.RemoveAll(x => x[0] == 'P');
            foreach (string pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("------------------------------------------------");
            //podemos remover também através do index com o RemoveAt
            // no exemplo iremos remover a pessoa do index 1
            pessoas.RemoveAt(1);

            foreach (string pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }
        }
    }
}