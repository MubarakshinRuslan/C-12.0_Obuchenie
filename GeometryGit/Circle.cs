namespace Geometry
{
    class Circle
    {
        Fdata fd;
        private double x;
        public double X
        {
            get => x;
            set => x = value;
        }

        private double y;
        public double Y
        {
            get => y;
            set => y = value;
        }

        private double radius;
        public double Radius
        {
            get => radius;
            set
            {
                if (value > 0)
                    radius = value;
                else
                    throw new ArgumentException("radius <= 0");
            }
        }

        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public Circle(int x, int y, int radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public void Move(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }

        public void PrintInfo()
        {
            Console.Write("Circle:" + X + "," + Y + " radius=" + Radius);
        }

        public override bool Equals(object? obj)
        {
            if (obj is Circle c)
                return this.Area() == c.Area();
            else
                return base.Equals(obj);
        }

        public int CompareTo(Circle c)
        {
            if (this.Area() > c.Area()) return 1;
            if (this.Area() < c.Area()) return -1;
            return 0;
        }

        public override int GetHashCode()
        {
            return (X, Y, Radius).GetHashCode();
        }

        public static bool operator == (Circle c1, Circle c2)
        {
            return object.Equals(c1, c2);
        }

        public static bool operator != (Circle c1, Circle c2)
        {
            return !(c1 == c2);
        }
    }
}
