using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeUC
{
    internal class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EPM_RATE_PER_HOUR = 20;
        public const int NUM_OF_WOKING_DAYS = 2;
        public const int MAX_HOUR_IN_MONTH = 10;
        static void Main(string[] args)
        {
            {
                int empHrs = 0, totalEmpHrs = 0, totalWorkingdays = 0;

                while (totalEmpHrs <= MAX_HOUR_IN_MONTH && totalWorkingdays < NUM_OF_WOKING_DAYS)
                {
                    totalWorkingdays++;
                    Random random = new Random();
                    int empCheck = random.Next(0, 3);
                    switch (empCheck)
                    {
                        case IS_PART_TIME:
                            empHrs = 4;
                            break;
                        case IS_FULL_TIME:
                            empHrs = 8;
                            break;
                        default:
                            empHrs = 0;
                            break;
                    }
                    totalEmpHrs += empHrs;

                    Console.WriteLine("Day# {0} Emp Hrs{1}", totalWorkingdays, empHrs);
                }

                int totalEmpWage = totalEmpHrs * EPM_RATE_PER_HOUR;
                Console.WriteLine("Total Emp Wage : {0}", totalEmpWage);

                Console.ReadLine();
            }
        }

    }
}
