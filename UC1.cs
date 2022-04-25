using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class UC1
    {
        public static void EmpolyeeWage()
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int num = random.Next(0, 2);

            if (num == IS_FULL_TIME)
            {
                Console.WriteLine("empolyee is present");
            }
            else
            {
                Console.WriteLine("empolyee is absent");
            }
        }
    }
}

