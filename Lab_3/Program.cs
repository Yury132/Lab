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

            Console.WriteLine("Несортированный ArrayList");
            foreach (var x in f1)
                Console.WriteLine(x.ToString());

            f1.Sort();
            Console.WriteLine("Отсортированный ArrayList");
            foreach (var x in f1)
                Console.WriteLine(x.ToString());


            for (int i = 0; i < 50; i++)
                Console.Write("-");
            Console.WriteLine("\n");
            Console.ReadKey();

        }
    }
}
