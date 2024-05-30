using Microsoft.VisualBasic.FileIO;
using System.Reflection;

namespace Module7
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            object obj = new BasePerson("Иван", "Петров", new DateTime(1990, 10, 25), "Мужчина");
            obj = 123;

            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] typesInfo = assembly.GetTypes();
            foreach (Type type in typesInfo)
            {
                Console.WriteLine(type.FullName);
                MethodInfo[] methodsInfo = type.GetMethods();
                if (methodsInfo.Length > 0)
                    Console.WriteLine("Methods:");
                foreach (var method in methodsInfo)
                {
                    string accessLevel = method.IsPrivate ? "private" : "public";
                    Console.WriteLine($"\t{accessLevel} {method.ReturnType} {method.Name}()");
                }
            }

            // Деструкторы не вызываются
        }
    }
}