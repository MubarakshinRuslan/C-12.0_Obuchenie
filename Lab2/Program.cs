using Lab2;

namespace Module3 
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число ворон на ветке: ");
            int n = int.Parse(Console.ReadLine());
            var crows = new Crows(n);
            Console.WriteLine(crows.GetCount());
        }
    }
}