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

            // так же есть другой способ вывода данных на консоль
            Console.WriteLine("Имя: {0}  Возраст: {2}  Рост: {1}м", name, height, age);
            Console.ReadKey();

            // получать информацию на консоль через метод Console.ReadLine().
            Console.Write("Введите свое имя: ");
            string name1 = Console.ReadLine();
            Console.WriteLine($"Привет {name1}");
            Console.ReadKey();

            /*
             * Однако минус этого метода является то, что Console.ReadLine считывает информацию 
             * именно в виде строки. Можно конвертировать в тип int или в тип double
             */
            Console.Write("Введите имя: ");
            string name2 = Console.ReadLine();

            Console.Write("Введите возраст: ");
            int age1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите рост: ");
            double height1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите размер зарплаты: ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Имя: {name2}  Возраст: {age1}  Рост: {height1}  Зарплата: {salary}руб");

            Console.ReadKey();
        }
    }
}
