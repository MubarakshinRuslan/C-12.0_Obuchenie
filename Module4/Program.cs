namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            foreach (var arg in args)
            {
                Console.Write(arg == args.Last() ? $"{arg} = " : $"{arg} + ");
                sum += int.Parse(arg);
            }
            Console.Write(sum);
        }
    }
}