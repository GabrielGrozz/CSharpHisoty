using Entities.Enums;

namespace Entities
{
    //quando temos método sabstratos não podemos utiliza-lo nas subclasses, a não ser que: transformemos a subclasse em abstrata, ou implementemos a classe abstrata
    //nesse exemplo iremos implementar a classe abstrata
    internal class Circle : Shape
    {

        internal double Radius { get; set; }


        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
        }

        //essa seria a implementacao da classe abstrata na nossa subclasse
        //basicamente será um override sobre o método abstrato da superclasse, porém não é necessário adicionar a palavra virtual no método original
        internal override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
