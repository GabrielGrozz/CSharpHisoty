namespace ConsoleApp3.Entities
{
    //essa seria uma classe normal, sem generics, sendo assim ela só aceita valores do tipo int, mas podemos fazer com que ela aceite outro tipos de valores
    //só iremos precisar transformala em uma classe generica como o GEnerics, que seria com o <g>
    //isso nos dara a possibilidadde de reuso

    //veja abaixo a classe de modo genetico
    internal class PrivateService<G>
    {
        //aqui iremos utilizar somente a letra
        //isso fara com que o valor que será retornar possa variar entro outro tipos, sejam eles string, number...
        private G[] _values = new G[10];
        private int _count = 0;

        //funcao que adiciona um valor no array
        public void AddValue(G value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("array is full");
            }
            _values[_count] = value;
            _count++;
        }

        //retorna o primeiro valor
        public G First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("array is empty");
            }
            return _values[0];
        }

        //mostrado todos os valores
        public void Print()
        {
            Console.Write('[');
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }
            if (_count > 0){
            Console.WriteLine(_values[_count - 1] + "]");
            }

        }
    }
}
