using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    abstract class Shape
    {
        public string color;
        public int topX;
        public int topY;

        public Shape(string _color, int _topX, int _topY)
        {
            color = _color;
            topX = _topX;
            topY = _topY;

        }

        public abstract string Show();


    }

    class Square : Shape
    {
        public int lourge;

        public Square(string _color, int _topX, int _topY, int _lourge)
            : base(_color, _topX, _topY)
        {
            lourge = _lourge;
        }

        public override string Show()
        {
            return "Нарисовать квадрат";
        }
    }

    class Circle : Shape
    {
        public int radius;

        public Circle(string _color, int _topX, int _topY, int _radius)
            : base(_color, _topX, _topY)
        {
            radius = _radius;
        }

        public override string Show()
        {
            return "Нарисовать круг";
        }
    }
}
