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
            int EmployeeWagePerHour = 20;
            int WorkingHour = 8;
            int Wage = EmployeeWagePerHour * WorkingHour;

            Random random = new Random();
            int EmployeeCheck = random.Next(2);

            {
                if (EmployeeCheck == EmployeePresent)

                {
                    Console.WriteLine("Employee Wage is:" + Wage);
                }

                else

                {
                    Console.WriteLine("Employee Wage is Zero");
                }
            }
        }
    }
}
