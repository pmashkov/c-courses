using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c_courses_class
{
    public class Square
    {
        public int topX;
        public int topY;
        public int lenght;
        public string color;

        public int area()
        {
            return lenght*lenght;
        }
        public int perimetr()
        {
            return lenght * 4;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Square box = new Square();
            string readKey;
            int  command = 0 ;

            while (command <= 0)
            {
                Console.Write("Введите длинну: ");
                readKey = Console.ReadLine();
                command = int.Parse(readKey);
                if (int.Parse(readKey) <= 0)
                    Console.WriteLine("Длинна !=0 && >0! Попробуйте еще раз");
                else 
                    box.lenght = int.Parse(readKey);
            }
            

            Console.WriteLine("Площадь = " + box.area());
            Console.WriteLine("Периметр = " + box.perimetr());

            Console.ReadKey();
        }
    }

//}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

///// <summary>
///// Точка
///// </summary>
//struct PointF
//{
//    public float X
//    {
//        get;
//        set;
//    }
//    public float Y
//    {
//        get;
//        set;
//    }
//}
///// <summary>
///// Квадрат
///// </summary>
//class Square
//{
//    PointF location;
//    float side;
//    /// <summary>
//    /// Конукторутор
//    /// </summary>
//    /// <param name="point">Точка, задающая положение нижнего левого угла.</param>
//    /// <param name="w">Длина строны квадрата</param>
//    public Square(PointF point, float w)
//    {
//        this.location = point;
//        this.side = w;
//    }
//    /// <summary>
//    /// Длина стороны квадрата
//    /// </summary>
//    public float Side
//    {
//        get
//        {
//            return this.side;
//        }
//        set
//        {
//            this.side = value;
//        }
//    }
//    /// <summary>
//    /// Площадь квадрата
//    /// </summary>
//    /// <returns></returns>
//    public float GetSquare()
//    {
//        return this.side * this.side;
//    }
//    /// <summary>
//    /// Переметр квадрата
//    /// </summary>
//    /// <returns></returns>
//    public float GetPerimetr()
//    {
//        return this.side * 4;
//    }
//    public PointF Location
//    {
//        get
//        {
//            return this.location;
//        }
//        set
//        {
//            this.location = value;
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Square square = new Square(new PointF { X = 5F, Y = 6F }, 3f);
//        Console.WriteLine("Сторона: " + square.Side);
//        Console.WriteLine("Площадь: " + square.GetSquare());
//        Console.WriteLine("Периметр: " + square.GetPerimetr());
//        square.Side = 10;
//        Console.WriteLine("Площадь: " + square.GetSquare());
//        Console.WriteLine("Периметр: " + square.GetPerimetr());
//        Console.ReadKey(true);
//    }
//}
