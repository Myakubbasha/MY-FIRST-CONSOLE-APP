using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class UC5
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;

        public static void EmpolyeeWage()
        {
            int emphrs = 0;
            int empwage = 0;
            int totalempwage = 0;

            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random obj = new Random();
                int num = obj.Next(0, 3);
                switch (num)
                {
                    case IS_PART_TIME:
                        emphrs = 4;
                        break;
                    case IS_FULL_TIME:
                        emphrs = 8;
                        break;
                    default:
                        emphrs = 0;
                        break;
                }
                empwage = emphrs * EMP_RATE_PER_HOUR;
                totalempwage = totalempwage + empwage;
                Console.WriteLine("the EMployee wage of the day is : " + empwage);
            }
            Console.WriteLine("total emp wage : " + totalempwage);
        }
    }
}

