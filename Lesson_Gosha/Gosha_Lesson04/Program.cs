using System;
using System.Collections.Generic;

namespace Gosha_Lesson04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание динамического массива
            List<short> digits = new List<short>();

            //Добавление данных в динамический массив
            digits.Add(5);
            digits.Add(15);
            digits.Add(25);
            digits.Add(45);

            // Создание динамического массива сразу с данными
            List<short> my = new List<short>() { 1, 0, 20, 45};
            // Так же можно будет добавлять данные, которые будут пребавлятся (начиная со значение 4 и так далее)
            my.Add(7);
        }
    }
}
