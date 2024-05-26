using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_Geometry_OOP
{
    public class Line : Shape
    {
        public int X1 {  get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public Line(int x1 = 0, int y1 = 0, int x2 = 0, int y2 = 0, string color = DefaultColor) : base(color)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        public override void Draw()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"Line point 1:({X1},{Y1}), point 2:({X2},{Y2}), Line color is {Color}.";
        }

        public void MoveBy(int dx, int dy)
        {
            X1 += dx;
            Y1 += dy;
            X2 += dx;
            Y2 += dy;
        }

        public void Scale(float scaleValue)
        {
            X2 = (int)Math.Round((X2 - X1) * scaleValue) + X1;
            Y2 = (int)Math.Round((Y2 - Y1) * scaleValue) + Y1;
        }
    }
}
