using Lab2;

namespace Module3 
{ 
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 1000; i++)
            {
                Crows crows = new Crows(i);
                //Console.WriteLine(crows.ExGetCount());\
                Console.WriteLine(crows.GetCount());
            }

        }
    }
}