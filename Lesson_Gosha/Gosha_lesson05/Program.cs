using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gosha_lesson05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            for (byte i = 0; i < 10; i++)
            {
                Console.WriteLine("Element - " + i);
            }
            */

            //Цикл while
            /*
            byte j = 0;
            while(j < 10)
            {
                Console.WriteLine("Element - " + j);
                j++;
            }

            short h = 1000;
            while(h > 127)
            {
                Console.WriteLine("Element - " + h);
                h -= 100;
            }
            */

            for (byte i = 1; i <= 40; i++)
            {
                if (i == 35)
                    break;
                Console.WriteLine("EL: " + i);
            }
        }
    }
}
