using System.Globalization;
using Entities.Enums;
using Entities;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //lista para as nossas formas
            List<Shape> shapesList = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int numberOfShapes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfShapes; i++)
            {
                Console.WriteLine($"Shape #{i + 1} data:");
                Console.Write("Rectangle or Circle? (r/c)? ");
                char ShapeType = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red): ");
                string ShapeColor = Console.ReadLine();
                //conversão da string recebida em Enum
                Color ShapeColorEnum = (Color)Enum.Parse(typeof(Color), ShapeColor);

                //se for retangulo...
                if (ShapeType == 'r')
                {
                    Console.Write("Width: ");
                    double ShapeWidth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Height: ");
                    double ShapeHeight = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapesList.Add(new Rectangle(ShapeColorEnum, ShapeWidth, ShapeHeight));
                } //se for circulo...
                else if (ShapeType == 'c')
                {
                    Console.Write("Radius: ");
                    double ShapeRadius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapesList.Add(new Circle(ShapeColorEnum, ShapeRadius));
                }
            }

            //log das areas
            Console.WriteLine("SHAPES AREAS:");
            foreach (Shape shape in shapesList)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine(shape.Color.ToString());
            }
        }
    }
}