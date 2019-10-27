using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    abstract class GeometricalFigure
    {
        public string Type { get; protected set; }

        public abstract double Area();
        public override string ToString()
        {
            return this.Type + " площадью " + this.Area().ToString();
        }
    }
}
