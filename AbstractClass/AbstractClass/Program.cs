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

            //possuimos também os metodos abstratos, são métodos que são genéricos, como por exemplo para calcular a area de algo, dependendo da forma será necessário uma forma de
            //calcular diferente 
        }
    }
}  