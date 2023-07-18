
// ------------ ESSA SERIA A NOSSA CLASSE NORMAL, MAS PRECISAMO DE UMA CLASSE QUE ACEITE TANTO STRING COMO INT, PARA ISSO IREMOS UTILIZAR O GENERICS (<G>) LOGO ABAIXOnamespace Generics.ENTITIES
//{
//    internal class GenericClass
//    {

//        private int[] _values = new int[5];
//        private int _count = 0;
//        public void AddValue(int value)
//        {
//            if (_count == 5)
//            {
//                throw new InvalidOperationException("_values is full");
//            }
//            _values[_count] = value;
//            _count++;
//        }

//        public int First()
//        {
//            if (_count == 0)
//            {
//                throw new InvalidOperationException("_values is empty");
//            }
//            return _values[0];
//        }


//        public void Print()
//        {
//            if (_count == 0)
//            {
//                throw new InvalidOperationException("_values is empty");
//            }
//            Console.Write("[");
//            // podemos tanto utilizar o _count como _values.Lenght
//            for (int i = 0; i < _count - 1; i++)
//            {
//                Console.Write(_values[i] + ", ");
//            }
//            if (_count > 0)
//            {
//                Console.Write(_values[_count - 1]);
//                Console.WriteLine("]");
//            }

//        }

//    }
//}

//-------------- COM GENERICS

namespace Generics.ENTITIES
{
    internal class GenericClass<G>
    {
        //precisamos passar a partir de agora o tipo que definimos( que no caso é o G) como o tipo dos objetos que vamor utilizar

        private G[] _values = new G[5];

        //como o _count não interfere em nada no tipo que irá ser armazenado no array não é necessário mudar o tipo dele para G
        private int _count = 0;
        public void AddValue(G value)
        {
            if (_count == 5)
            {
                throw new InvalidOperationException("_values is full");
            }
            _values[_count] = value;
            _count++;
        }

        public G First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("_values is empty");
            }
            return _values[0];
        }


        public void Print()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("_values is empty");
            }
            Console.Write("[");
            // podemos tanto utilizar o _count como _values.Lenght
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }
            if (_count > 0)
            {
                Console.Write(_values[_count - 1]);
                Console.WriteLine("]");
            }

        }

    }
}
