using System;
using System.Collections.Generic;
using System.Text;
namespace EmployeeWage
{
    public class Employee
    {
        public static void Main(string[] args)
        {
            int EmployeeAbsent = 0;
            int EmployeePresentFullTime = 1;
            int EmployeePresentPartTime = 2;
            int EmployeeWagePerHour = 20;
            int WorkingHourFullDay = 8;
            int WorkingHourPartTime = 4;
            int WageFullTime = EmployeeWagePerHour * WorkingHourFullDay;
            int WagePartTime = EmployeeWagePerHour * WorkingHourPartTime;

            Random random = new Random();
            int EmployeeCheck = random.Next(3);


            switch (EmployeeCheck)

            {
                case 0:
                    Console.WriteLine("Employee Wage is Absent");
                    break;

                case 1:
                    Console.WriteLine("Employee is Present For Full Day and Wage is:" + WageFullTime);
                    break;

                case 2:
                    Console.WriteLine("Employee is Present For Part Time and Wage is:" + WagePartTime);
                    break;

            }
        }
    }
}
