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

            int EmpHour = 0;
            int EmpWage = 0;

            int totalEmpHour = 0;
            int totalEmpWorkingDays = 0;

            int TotalWorkingHour = 100;
            int TotalWorkingDays = 20;

            while (totalEmpHour < TotalWorkingHour && totalEmpWorkingDays < TotalWorkingDays)
            {
                totalEmpWorkingDays++;
                Random random = new Random();
                int EmployeeCheck = random.Next(2);

                if (EmployeeCheck == EmployeePresent)

                {
                    Console.WriteLine("Employee is Present");
                    EmpHour = 8;
                }

                else

                {
                    Console.WriteLine("Employee is Absent");
                    EmpHour = 0;
                }
                totalEmpHour = totalEmpHour + EmpHour;
                {
                    Console.WriteLine("Total Employee Working Hour is :" + totalEmpHour);
                }
            }
        }
    }
}
