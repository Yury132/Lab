using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {   
        static void color(int k)
        {
            switch (k) {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
            }
        }
        static int Main(string[] args)
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
                    Console.WriteLine("Необходимо ввести вещественные числа!");
                }
            } while (!f1 || !f2 || !f3);

            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            Console.WriteLine(c.ToString());

            if(a==0 && b==0 && c==0)
            {
                color(2);
                Console.WriteLine("Бесконечное Количество Корней");
                return (0);
            }

            if(a==0 && b == 0)
            {
                color(1);
                Console.WriteLine("Корней Нет");
                return (0);
            }

            if (a == 0)
            {
                double var = -c/b;
                if(var < 0)
                {
                    color(1);
                    Console.WriteLine("корней Нет");
                    return (0);
                }
                else if (var == 0)
                {
                    color(2);
                    Console.WriteLine("x1=0");
                    return (0);
                }
                else
                {
                    color(2);
                    double x1 = Math.Sqrt(var), x2 = -Math.Sqrt(var);
                    Console.WriteLine("x1= " + x1.ToString() + " x2= " + x2.ToString());
                    return (0);
                }
            }






            return (0);
        }
    }
}
