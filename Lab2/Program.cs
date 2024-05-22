using Lab2;

namespace Module3 
{ 
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Введите число ворон на ветке: ");
            //int n = int.Parse(Console.ReadLine());
            //var crows = new Crows(n);
            //Console.WriteLine(crows.GetCount());

            Console.WriteLine("Введите число, факториал которого Вы хотите вычислить: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Вычисление по Ffactorial: {number}! = {Factorial.Ffactorial(number)}");
            Console.WriteLine($"Вычисление по Rfactorial: {number}! = {Factorial.Rfactorial(number)}");
        }
    }
}