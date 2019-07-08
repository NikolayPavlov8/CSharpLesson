using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Gosha
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");

            short num;
            bool hasCar = true;
            Console.Write("Введите первое число: ");
            num = Convert.ToInt16(Console.ReadLine());

            if (num == 10)
            {
                Console.WriteLine("Число равно 10");
            }
            else if (num >= 50)
            {
                if (num < 100 && hasCar == true)
                {
                    Console.WriteLine("Число меньше 100");
                }
                Console.WriteLine("Число больше 50");
            }
            else
            {
                Console.WriteLine("Число неизвестно");
            }



            Console.ReadKey();
        }
    }
}
