using MultiCast_Delegate;

//podemos usar o delegates de uma forma de multicasting com o +=

//declaracao do delegate
delegate void BinaryOperations();

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //assim seria a declaração de um delegate com multicastig, agora quando chamarmos ele, ele irá executar
            //todos os métodos que nele contém
            BinaryOperations op = Operations.Green;
            op += Operations.Gold;

            op.Invoke();

        }
    }

}
