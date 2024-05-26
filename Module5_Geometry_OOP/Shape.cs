using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_Geometry_OOP
{
    public abstract class Shape
    {
        public const string DefaultColor = "Black";
        public string Color { get; set; }

        public Shape(string color = DefaultColor)

        {
            Color = color;
        }
        public abstract void Draw();
    }
}
