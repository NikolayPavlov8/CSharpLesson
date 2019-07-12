using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06
{
    class Program
    {
        static void Main(string[] args)
        {
            //string data;
            //data = Console.ReadLine();
            //Console.WriteLine("Привет " + data + "!!!");

            string str1 = "5";
            string str2 = "2";
            Console.WriteLine(str1 + str2);     //выполнение плюс, выведет 52
            int a = Convert.ToInt32(str1);
            int b = Convert.ToInt32(str2);
            Console.WriteLine(a + b);

            string str;
            int d, c;
            Console.WriteLine("Введите число 1");
            str = Console.ReadLine();
            d = Convert.ToInt32(str);

            Console.WriteLine("Введите число 2");
            str = Console.ReadLine();
            c = Convert.ToInt32(str);

            int result = d + c;
            Console.WriteLine("Сумма чисел = " + result);


        }
    }
}
