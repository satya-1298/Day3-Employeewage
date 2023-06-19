using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    public class EmployeeInfo
    {


        public void Display()
        {
            int EmpHrs = 0;
            int wage = 0;
            int Wage_Per_Hour = 20;
            int Full_Day_Hours = 8;
            int Part_Time_Hours = 4;
            int Monthly_Days = 20;
            Random random = new Random();
            int attendent = random.Next(3);
            Console.WriteLine(attendent);
                switch (attendent)
                {
                    case 1:
                        Console.WriteLine("Full_Timer");
                    EmpHrs = 8;
                        break;
                    case 2:
                        Console.WriteLine("Part_Timer");
                    EmpHrs = 4;
                        break;
                    default: Console.WriteLine("Employee absent");
                    break;

                }
            wage = EmpHrs * Wage_Per_Hour * Monthly_Days;
                Console.WriteLine("Daily Wages of Employee : " + wage);           
        }
    }
}
