using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * конвертация строки
 * parse и tryparse
 */

namespace Lesson07
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "5";
            int a = int.Parse(str);

            string str1 = "5,9";
            double b = double.Parse(str1);

            // как можно сделать проверку конвертации без ошибки выброса
            string str2 = "5,9fhghdd";
            try
            {
                int c = Convert.ToInt32(str2);
                Console.WriteLine("Успешная конвертация");
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка при конвертации");
            }

            // метод tryparse
            string str3 = "1";
            int d;
            //так как при неудачном конвертировании будут не правельные значение, то надо пресвоить результат bool
            bool result = int.TryParse(str3, out d);

            if (result)
            {
                Console.WriteLine("Операция успешна, значение = " + d);
            }
            else
            {
                Console.WriteLine("Не удается конвертировать!");
            }
        }
    }
}
