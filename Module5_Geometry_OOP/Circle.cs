using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Module5_Geometry_OOP
{
    public class Circle : Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        private int _Radius;
        public int Radius
        {
            get => _Radius;
            set
            {
                if (value > 0)
                {
                    _Radius = value;
                }
                else
                {
                    throw new ArgumentException("radius <= 0");
                }
            }
        }
        public Circle(int x = 0, int y = 0, int radius = 1, string color = DefaultColor) : base(color)
        {
            X = x;
            Y = y;
            Radius = radius;
        }
        public void MoveBy(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }
        public void Scale(double scaleValue)
        {
            Radius = (int)Math.Round(scaleValue * Radius);
        }
        public override void Draw()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"Circle center point is ({X},{Y}), radius is {Radius}.";
        }
    }
}
