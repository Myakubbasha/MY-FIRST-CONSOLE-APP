using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class UC9
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHourPerMonth;
        private int totalempwage;

        public void EmpWageBuilderObject(string company, int empRatePerHour, int numOfWorkingDays, int maxHourPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHourPerMonth = maxHourPerMonth;
        }
        public void EmpolyeeAttendences()
        {
            int emphrs = 0;
            //int empwage = 0;
            int totalEmpHr = 0;
            int totalWorkingDays = 0;


            while (totalEmpHr <= this.maxHourPerMonth && totalWorkingDays < this.numOfWorkingDays)
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

            totalempwage = totalEmpHr * this.empRatePerHour;
            Console.WriteLine("total emp wage for company  : " + company + "is :" + totalempwage);
            //int totalempwage1 = totalempwage;
            //Console.WriteLine("total emp wage for company  : " + company + "is :" totalempwage1);
        }

        public string toString()
        {
            return "total emp wage for company: " + this.company + "is: " + this.totalempwage;
        }
    }
}

