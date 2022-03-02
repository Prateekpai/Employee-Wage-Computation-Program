using System;
using System.Collections.Generic;
using System.Text;
namespace EmployeeWage
{
    public class Employee
    {
        public static void Main(string[] args)
        {
            int EmployeePresent = 1;

            Random random = new Random();
            int EmployeeCheck = random.Next(2);

            if (EmployeeCheck == EmployeePresent)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
