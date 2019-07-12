using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 3. Напишите простой конвертор валют
 *    (без восможности динамического выбора валюты пользователем).
 *    Валюты заданы хардкором и не изменяются. Тип валюты на выбор программиста.
 */

namespace Dom_Lesson03
{
    class Program
    {
        static void Main(string[] args)
        {
            double UsdToRub = 66.29;
            double UsdToUah = 27.24;
            double USD;

            Console.WriteLine("Введите сумму в USD");

            USD = double.Parse(Console.ReadLine());

            Console.WriteLine(USD + "USD в RUB" + USD * UsdToRub);
            Console.WriteLine(USD + "USD в UAH" + USD * UsdToUah);
        }
    }
}
