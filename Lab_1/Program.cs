using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Усынин Юрий ИУ5-35Б";

            bool f1, f2, f3;
            double a, b, c;
            do
            {
                Console.Write("Введите коэф А: ");
                f1 = double.TryParse(Console.ReadLine(), out a);
                Console.Write("Введите коэф B: ");
                f2 = double.TryParse(Console.ReadLine(), out b);
                Console.Write("Введите коэф C: ");
                f3 = double.TryParse(Console.ReadLine(), out c);

                if (!f1 || !f2 || !f3)
                {
                    Console.Write("Необходимо ввести вещественные числа!");
                }
            } while (!f1 || !f2 || !f3);

            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            Console.WriteLine(c.ToString());
        }
    }
}
