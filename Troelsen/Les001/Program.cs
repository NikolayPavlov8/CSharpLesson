using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Console I/O *****");
            GetUserData();
            Console.ReadLine();
        }
        private static void GetUserData()
        {
            // Полочить информацию об имени и возрасте.
            Console.WriteLine("Введите ваше имя: ");        // Предложение ввести имя.
            string userName = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст: ");     // Предложить ввести возраст.
            string userAge = Console.ReadLine();

            //Просто ради забавы изменить цвет переднего плана.
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Вывести полученную информацию на консоль.
            Console.WriteLine("Hello {0}! You are {1} years old", userName, userAge);

            //Восстановить предыдущий цвет переднего плана.
            Console.ForegroundColor = prevColor;
        }
    }
}
