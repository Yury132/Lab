using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10, 5);
            Circle circle = new Circle(10);
            Square square = new Square(5);

            ArrayList f1 = new ArrayList();

            f1.Add(rectangle);
            f1.Add(square);
            f1.Add(circle);

            Console.WriteLine("\nСодержимое коллекции: ");
            foreach (var x in f1)
                Console.WriteLine(x.ToString());

            for (int i = 0; i < 50; i++)
                Console.Write("-");
            Console.WriteLine("\n");
            //-------------------------------------------------------------------------------------

            List<GeometricalFigure> f2 = new List<GeometricalFigure>();
            f2.Add(circle);
            f2.Add(rectangle);
            f2.Add(square);

            Console.WriteLine("\nПеред сортировкой: ");
            foreach (var x in f2)
                Console.WriteLine(x.ToString());

            f2.Sort();
            Console.WriteLine("\nПосле сортировки: ");
            foreach (var x in f2)
                Console.WriteLine(x.ToString());

            for (int i = 0; i < 50; i++)
                Console.Write("-");
            Console.WriteLine("\n");
            //-------------------------------------------------------------------------------------

            Console.WriteLine("\nМатрица: ");
            Matrix<GeometricalFigure> matrix = new Matrix<GeometricalFigure>(3, 3, new FigureMatrixCheckEmpty());

            matrix[0, 0] = rectangle;
            matrix[1, 1] = square;
            matrix[2, 2] = circle;
            Console.WriteLine(matrix.ToString());

            for (int i = 0; i < 50; i++)
                Console.Write("-");
            Console.WriteLine("\n");
            //-------------------------------------------------------------------------------------


            SimpleList<GeometricalFigure> list = new SimpleList<GeometricalFigure>();
            list.Add(circle);
            list.Add(rectangle);
            list.Add(square);

            Console.WriteLine("\nПеред Сортировкой: ");
            foreach (var x in list)
                Console.WriteLine(x.ToString());

            list.Sort();
            Console.WriteLine("\nПосле Сортировки: ");
            foreach (var x in list)
                Console.WriteLine(x.ToString());

            for (int i = 0; i < 50; i++)
                Console.Write("-");
            Console.WriteLine("\n");
            //-------------------------------------------------------------------------------------



            Console.ReadKey();

        }
    }
}
