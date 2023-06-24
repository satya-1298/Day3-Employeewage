using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    public class EmployeeInfo
    {


        public static void Display()
        {
            int Total_Wage = 0;
            int Emp_Hours = 0;
            int wage = 0;
            int days = 0;
            int Total_Hours = 0;
            int Wage_Per_Hour = 20;
            //int Full_Day_Hours = 8;
            //int Part_Time_Hours = 4;
            int Monthly_Days = 20;
            int Max_Hours = 100;
            Random random = new Random();
            while (days < Monthly_Days && Total_Hours < Max_Hours)
            {
                int attendent = random.Next(3);
                Console.WriteLine(attendent);

                switch (attendent)
                {
                    case 1:
                        Console.WriteLine("Full_Timer");
                        Emp_Hours = 8;

                        break;
                    case 2:
                        Console.WriteLine("Part_Timer");
                        Emp_Hours = 4;
                        break;
                    default:
                        Console.WriteLine("Employee Absent");
                        Emp_Hours = 0;
                        break;
                }
                days++;
                Console.WriteLine("Days are  " + days);
                Total_Hours += Emp_Hours;
                wage = Emp_Hours * Wage_Per_Hour;
                Total_Wage = Total_Wage + wage;
                Console.WriteLine("Employee wages  = " + wage);
                Console.WriteLine(" employee  Hours = " + Total_Hours);
                Console.WriteLine("Total Employee wage  = " + Total_Wage);
                Console.WriteLine("\n");
            }
            Console.WriteLine(" Monthly Wages of Employee : " + Total_Wage);

        }
    }
}
