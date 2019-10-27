using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Rectangle : GeometricalFigure, IPrint
    {
        public double height { get; set; }
        public double width { get; set; }
        public Rectangle(double w, double h)
        {
            height = h;
            width = w;
            this.Type = "Прямоугольник";
        }

        public override double Area()
        {
            return this.width * this.height;
        }

        public override string ToString()
        {
            return this.Type + " с шириной: " + this.width.ToString() + " и с высотой: " + this.height.ToString() + " имеет площадь: " + this.Area().ToString();
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
