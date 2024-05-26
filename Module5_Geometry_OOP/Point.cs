using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_Geometry_OOP
{
    public class Point : Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x = 0, int y = 0, string color = DefaultColor) : base(color)
        {
            X = x;
            Y = y;
        }

        public override void Draw()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"Point at ({X},{Y}), Point Color is {Color}.";
        }

        public void MoveBy(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }
    }
}
