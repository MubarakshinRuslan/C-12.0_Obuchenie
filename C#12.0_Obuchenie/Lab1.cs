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
            public int x0, y0;
            public int color;
            public Figures type;
        }

        public static void Main(string[] args)
        {
            Fdata fd;
            fd.x0 = 1;
            fd.y0 = 1;
            fd.type = Figures.Romb;

            Console.WriteLine("Fdata fd:");
            Console.Write($"fd.x0 = {fd.x0}\nfd.y0 = {fd.y0}\nfd.type = {fd.type}");
        }
    }
}