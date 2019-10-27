using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Circle : GeometricalFigure, IPrint
    {
        public double radius { get; set; }
        public Circle(double r)
        {
            this.radius = r;
            this.Type = "Круг";
        }
        public override double Area()
        {
            return Math.PI * this.radius * this.radius;
        }
        public override string ToString()
        {
            return this.Type + " с радиусом: " + this.radius.ToString() + " имеет площадь: " + this.Area().ToString();
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
