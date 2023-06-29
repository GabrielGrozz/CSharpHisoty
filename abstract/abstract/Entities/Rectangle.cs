using Entities.Enums;

namespace Entities
{
    //quando temos método sabstratos não podemos utiliza-lo nas subclasses, a não ser que: transformemos a subclasse em abstrata, ou implementemos a classe abstrata
    //nesse exemplo iremos implementar a classe abstrata
    internal class Rectangle : Shape
    {
        internal double Width { get; set; }
        internal double Height { get; set; }
        internal Rectangle(Color color,double width, double height) : base(color)
        {
            Width = width;
            Height = height;

        }

        //essa seria a implementacao da classe abstrata na nossa subclasse
        //basicamente será um override sobre o método abstrato da superclasse, porém não é necessário adicionar a palavra virtual no método original
        internal override double Area()
        {
            return Width * Height;
        }
    }
}
