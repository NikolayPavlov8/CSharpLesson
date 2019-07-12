using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gosha_Lesson03
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] digits = new byte[5];
            digits[0] = 3;
            digits[4] = 255;

            Console.WriteLine(digits[4]);
            string[] students = new string[] { "Bob", "Mickle", "George", "Alex" };
            Console.WriteLine(students[1]);

            int[,] numbers = {
                {5, 7, 2 },
                {9, 200, 8 },
                {7, 0, 12 }
            };
            numbers[1, 1] = 50;
            Console.WriteLine(numbers[1, 1]);

            // Узнаем длину массива
            int len = students.Length;
            Console.WriteLine(len);

            //Копирование массива в массив
            string[] copyStudents = new string[students.Length];
            students.CopyTo(copyStudents, 0);
            Console.WriteLine(copyStudents[1]);

            // Очистить массив
            Array.Clear(students, 0, students.Length);

            //Создание 2мерного массива без заполнения
            short[,] nums = new short[5, 2];
        }
    }
}
