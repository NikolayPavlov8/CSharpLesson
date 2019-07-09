using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  Функции
 */

namespace Gosha_Lesson06
{
    class Program
    {
        static void Main(string[] args)
        {
            print("Привет, мир!", 10);
            string name = "Георгий";
            print(name, 100);
            print("Что-то", 50);

            int x = 5, c = 2;
            int result = summ(x, c);
            print("сумма", result);
        }

        public static void print(string words, int number)
        {
            Console.WriteLine("Переменная: {0}, число: {1}", words, number);
        }

        public static int summ(int a, int b)
        {
            int res = a + b;
            return 0;
        }
    }
}
