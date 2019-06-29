using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05
{
    class Program
    {
        static void Main(string[] args)
        {

            string hello = "Привет Мир";
            Console.WriteLine(hello);
            Console.WriteLine("Добро пожаловать в C#");
            Console.WriteLine("Пока мир ...");
            Console.WriteLine(24.5);

            Console.ReadKey();

            string name = "Tom";
            int age = 34;
            double height = 1.7;
            Console.WriteLine($"Имя: {name} Возраст: {age} Рост {height} м");
            Console.ReadKey();


        }
    }
}
