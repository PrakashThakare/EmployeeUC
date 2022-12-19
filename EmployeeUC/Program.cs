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
            Random random = new Random();


            //Coputaion
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Not Present");
            }
            Console.ReadLine();
        }
    }
}
