using System;


namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(7, 8.2);
            Square square = new Square(4.5);
            Circle circle = new Circle(11);

            rect.Print();
            square.Print();
            circle.Print();

            Console.ReadKey();

        }
    }
}