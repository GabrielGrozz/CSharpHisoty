using AbstractClass;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //não podemos instanciar uma classe abstrata, senão teremos o seguindo erro, mas podemos instanciar subclasses da classe abstrata
            AbstractPerson pessoa = new AbstractPerson();
            Employee employee = new Employee();
        }
    }
}  