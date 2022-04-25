using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class UC8
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public static int EmpolyeeAttendences(string company, int empRatePerHour, int numOfWorkingDays, int maxHourPerMonth)
        {


            int emphrs = 0;
            //int empwage = 0;
            int totalEmpHr = 0;
            int totalWorkingDays = 0;
            int totalempwage = 0;

            while (totalEmpHr <= maxHourPerMonth && totalWorkingDays < numOfWorkingDays)
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
                totalEmpHr += emphrs; // totalEmpHr = totalEmpHr + emphrs;
                Console.WriteLine("day#: " + totalWorkingDays + " Emp Hrs " + emphrs);

            }
            totalempwage = totalEmpHr * empRatePerHour;
            Console.WriteLine("total emp wage : " + totalempwage);
            return totalempwage;
        }
    }
}

