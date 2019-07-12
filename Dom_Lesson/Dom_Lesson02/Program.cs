using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 2. Введите 3 числа и выведите на экран значение суммы и произведения этих чисел.
 */

namespace Dom_Lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue, thirdValue;

            Console.WriteLine("Введите число 1");

            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 2");

            secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 3");

            thirdValue = double.Parse(Console.ReadLine());

            double sumResult = firstValue + secondValue + thirdValue;

            double multResult = firstValue * secondValue * thirdValue;

            Console.WriteLine("Сумма трёх чисел " + sumResult);
            Console.WriteLine("Произведение 3 чисел " + multResult);
        }
    }
}
