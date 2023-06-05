using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace retangulo
{
    internal class Rectangle
    {
        public double Width;
        public double Height;

        public double Area()
        {
            double area = Width * Height;
            return area;
        }

        public double Perimeter()
        {
            double perimeter = (Width * 2) + (Height * 2);
            return perimeter;
        }

        public double Diagonal()
        {
            double diagonal = Math.Sqrt(Math.Pow(Width, 2.00) + Math.Pow(Height, 2.00));
            return diagonal;
        }
    }
}
