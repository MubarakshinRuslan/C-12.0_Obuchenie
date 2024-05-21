namespace Module2
{
    class Lab1
    {
        enum Figures
        {
            Romb = 1,
            Circle,
            Rect,
            Square,
            Triangle
        }
        struct Fdata
        {
            public int X, Y;
            public int Color;
            public Figures Type;
        }

        public static void Main(string[] args)
        {
            Fdata fd;
            fd.X = 10;
            fd.Y = -5;
            fd.Type = Figures.Romb;

            Console.WriteLine("Fdata fd:");
            Console.Write($"fd position is ({fd.X},{fd.Y})\nfd.type = {fd.Type}");
        }
    }
}