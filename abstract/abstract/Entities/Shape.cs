using Entities.Enums;

namespace Entities
{
    internal abstract class Shape
    {
        internal Color Color { get; set; }
        internal Shape(Color color)
        {
            Color = color;
        }

        //esse é um método abstrato, logo necessáriamente precisamos que a classe seja abstrata para podermos utiliza-la
        internal abstract double Area();
    }
}
