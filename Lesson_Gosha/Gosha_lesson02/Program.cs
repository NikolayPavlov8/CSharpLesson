using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gosha_lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "User";

            switch (name)
            {
                case "bob":
                    Console.Write("Имя Боб");
                    break;
                case "User":
                    Console.Write("User");
                    break;
                default:
                    Console.Write("Какое то другое имя");
                    break;
            }

            Console.ReadKey();
        }
    }
}
