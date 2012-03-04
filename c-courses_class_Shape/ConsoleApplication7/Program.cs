using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] showShape = new string[10];
            Random randomShow = new Random();

            //Shape shape = new Shape("red", 2, 2);
            //Console.WriteLine(shape.color + " - цвет");

            Square square = new Square("red", 2, 2, 4);
            Console.WriteLine(square.lourge + " - длинна");

            Circle circle = new Circle("red", 2, 2, 5);
            Console.WriteLine(circle.radius + " - радус");


            //Далее следует очень корявый цикл) Прошу больно бить ногами
            //и сказать как сделать красивее/лучше... мб через enum можно?
            for (int i = 0; i < 10; i++)
            {
                if (randomShow.Next(0, 2) == 0)
                    showShape[i] = square.Show();
                else
                    showShape[i] = circle.Show();

                Console.WriteLine(showShape[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                if (showShape[i] == "Нарисовать круг")
                Console.WriteLine(showShape[i]);
            }

            Console.ReadKey();
        }
    }
}
