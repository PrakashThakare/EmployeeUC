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
        static void Main(string[] args)
        {
            {
                int empHrs = 0, empWage = 0, totalEmpWage = 0;

                for (int day = 0; day < NUM_OF_WOKING_DAYS; day++)
                {
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
                    empWage = empHrs * EPM_RATE_PER_HOUR;
                    totalEmpWage += empWage;
                    Console.WriteLine("Emp Wage{0}", empWage);
                }

                Console.WriteLine("Total Emp Wage : {0}", totalEmpWage);

                Console.ReadLine();
            }
        }

    }
}
