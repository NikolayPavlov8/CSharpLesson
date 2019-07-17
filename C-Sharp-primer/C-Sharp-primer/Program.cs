using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_primer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Базовые операции String

            string h = "Hello";
            Console.WriteLine("h = {0}", h);
            Console.WriteLine("Длина h = {0}", h.Length);
            Console.WriteLine("h в верхнем регистре = {0}", h.ToUpper());
            Console.WriteLine("h = {0}", h);
            Console.WriteLine("h в нижнем регистре = {0}", h.ToLower());
            Console.WriteLine("h содеожит e? : {0}", h.Contains("е"));
            Console.WriteLine("Замена {0}", h.Replace("lo", ""));
        }
    }
}
