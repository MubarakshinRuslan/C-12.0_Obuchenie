﻿using System;

namespace Geometry
{
    public enum Figures { Romb, Rect, RightTriangle, Circle }

    public struct Fdata
    {
        public int x0, y0;
        public double a, b;
        public int color;
        public Figures type;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rect rect = new Rect(new Fdata() {x0=1,y0=1,a=3,b=5});
            rect.Move(2, 1);
            rect.PrintInfo();
            Console.WriteLine(rect.Area());

            RightTriangle rt = new RightTriangle(new Fdata() { x0 = -1, y0 = -3, a = 1, b = 4 });
            rt.Move(1, 1);
            rt.PrintInfo();
            Console.WriteLine(rt.Area());

            //Ваш код!


            object[] data = {rect, rt};
            Print(data);

            Circle c1 = new Circle(10, 20, 30);
            Circle c2 = new Circle(3, 5, 10);
            Circle c3 = new Circle(4, 10, 30);

            Console.WriteLine("------------");
            Console.WriteLine(c1 == c2);
            Console.WriteLine(c2 == c3);
            Console.WriteLine(c3 == c1);
        }

        public static void Print(object[] data)
        {

        }
    }
}
