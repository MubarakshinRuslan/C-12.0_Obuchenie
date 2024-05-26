using Module5_Geometry_OOP;

namespace Module5_Geometry_OOP
{
    class Program
    {
        static void DrawScene(Shape[] scene)
        {
            foreach(Shape shape in scene)
            {
                shape.Draw();
            }
        }

        static void Main(string[] args)
        {
            Shape[] scene =
            [
                new Circle(x: 1, y: 10, radius: 15, color: "White"),
                new Point(),
                new Point(color: "red"),
                new Line(x1: 0, y1: 0, x2: 13, y2: 5)
            ];

            DrawScene(scene);
        }
    }
}



