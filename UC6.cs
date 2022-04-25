using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class UC6
    {

        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        public const int MAX_HR_IN_MONTH = 10;
        public static void EmpolyeeAttendences()
        {


            int emphrs = 0;
            //int empwage = 0;
            int totalEmpHr = 0;
            int totalWorkingDays = 0;
            int totalempwage = 0;

            while (totalEmpHr <= MAX_HR_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
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
                totalEmpHr += emphrs;
                Console.WriteLine("day#:" + totalWorkingDays + "Emp Hrs" + emphrs);

            }
            totalempwage = totalEmpHr * EMP_RATE_PER_HOUR;
            Console.WriteLine("total emp wage : " + totalempwage);
        }
    }
}

