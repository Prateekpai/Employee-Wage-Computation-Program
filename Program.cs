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
            int TotalWorkingDaysPerMonth = 20;
            int EmployeeWagePerHour = 20;
            int WorkingHourFullDay = 8;
            int WorkingHourPartTime = 4;
            int MonthWageFullTime = TotalWorkingDaysPerMonth * EmployeeWagePerHour * WorkingHourFullDay;
            int MonthWagePartTime = TotalWorkingDaysPerMonth * EmployeeWagePerHour * WorkingHourPartTime;

            Random random = new Random();
            int EmployeeCheck = random.Next(3);

            {
                if (EmployeeCheck == EmployeePresentFullTime)

                {
                    Console.WriteLine("Employee Monthly Wage for Full Time Job :" + MonthWageFullTime);
                }

                else if (EmployeeCheck == EmployeePresentPartTime)
                {
                    Console.WriteLine("Employee Monthly Wage for Part Time Job :" + MonthWagePartTime);
                }
                else

                {
                    Console.WriteLine("Employee is Absent");
                }
            }
        }
    }
}
