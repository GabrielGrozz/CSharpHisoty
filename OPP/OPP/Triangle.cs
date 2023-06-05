using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{ //criamos uma classe, que será o nosso objeto Triangle, que poderá ser utilizado no nosso projeto principal
    internal class Triangle
    {
        //Precisamos setar eles como public para que possamos utiliza-los no nosso projeto principal
        public double A, B, C;


        //podemos criar métodos dentro das classes, assim sendo necessário apenas chama-los no projeto principal
        public double Area()
        {
            double p = (A + B + C) / 2.0; 
            double area = (double)Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return area;
        }
    }
}



