using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class FigureMatrixCheckEmpty : IMatrixCheckEmpty<GeometricalFigure>
    {
        public GeometricalFigure getEmptyElement()
        {
            return null;
        }
        public bool checkEmptyElement(GeometricalFigure element)
        {
            bool Result = false;
            if(element == null)
            {
                Result = true;
            }
            return Result;
        }
    }
}
