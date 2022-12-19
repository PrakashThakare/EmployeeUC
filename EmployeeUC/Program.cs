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
            int IS_PART_TIME = 1;          //Constant
            int IS_FULL_TIME = 2;          //Constants
            int EPM_RATE_PER_HOUR = 20;    //Constants

            int empHrs = 0;        //veriable
            int empWage = 0;       //veriable

            Random random = new Random();
            int empCheck = random.Next(0, 3);

            if (empCheck == IS_PART_TIME)
            {
                empHrs = 4;
            }
            else if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EPM_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage is: {0}", empWage);
            Console.ReadLine();
        }
    }
    
}
