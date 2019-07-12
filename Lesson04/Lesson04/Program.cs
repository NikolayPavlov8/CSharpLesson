// Начало секций подключаемых пространств имен

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// объявление нового пространства имен
namespace Lesson04 
{
    class Program       // объявление нового класса
    {
        static void Main(string[] args)         // объявление нового метода
        {

            Console.Write("Введите свое имя: ");

            // этот метод может считать с консоля строку
            string name = Console.ReadLine();           // вводим имя

            // затем введенное имя выводится на консоль
            Console.WriteLine($"Привет {name}");        // выводим имя на консоль

            // эта строка, тоже самое, что и выше строкой
            Console.WriteLine("Привет " + name);

            Console.ReadKey();


        }       // конец метода
    }           // конец класса
}               // конец пространства имен
