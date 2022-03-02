using System;
using System.Collections.Generic;
using System.Text;
namespace EmployeeWage
{
    public class Employee
    {
        public static void Main(string[] args)
        {
            int EmployeePresentFullTime = 1;
            int EmployeePresentPartTime = 2;
            int EmployeeWagePerHour = 20;
            int WorkingHourFullDay = 8;
            int WorkingHourPartTime = 4;
            int WageFullTime = EmployeeWagePerHour * WorkingHourFullDay;
            int WagePartTime = EmployeeWagePerHour * WorkingHourPartTime;

            Random random = new Random();
            int EmployeeCheck = random.Next(3);

            {
                if (EmployeeCheck == EmployeePresentFullTime)

                {
                    Console.WriteLine("Employee is Present For Full Day and Wage is:" + WageFullTime);
                }

                else if (EmployeeCheck == EmployeePresentPartTime)
                {
                    Console.WriteLine("Employee is Present For Part Time and Wage is:" + WagePartTime);
                }
                else

                {
                    Console.WriteLine("Employee Wage is Absent");
                }
            }
        }
    }
}
