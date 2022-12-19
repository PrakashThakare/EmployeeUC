using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeUC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to EmployeeUC");
            // Constants
            int IS_FULL_TIME = 1;
            //Coputaion
            int EMP_RATE_PER_HOUR = 20;

            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Daily Employee Wage is: {0}", empWage);

            Console.ReadLine();
        }
    }
}
