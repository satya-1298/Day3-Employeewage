using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    public class EmployeeInfo
    {


        public static void Display(string company, int wage_Per_Hour, int daily_Hours, int monthly_WorkDays)
        {
            int daily_Wage = 0;
            int montly_Wage = 0;
            int emp_Hours = 0;
            Random random = new Random();
            int attendent = random.Next(3);
            Console.WriteLine(attendent);

            switch (attendent)
            {
                case 1:
                    Console.WriteLine("Full_Timer");
                    emp_Hours = 8;

                    break;
                case 2:
                    Console.WriteLine("Part_Timer");
                    emp_Hours = 4;
                    break;
                default:
                    Console.WriteLine("Employee Absent");
                    emp_Hours = 0;
                    break;
            }
            daily_Wage = wage_Per_Hour * daily_Hours;
            int monthly_wage = daily_Wage * monthly_WorkDays;
            Console.WriteLine("Daily wages of {0} ",company+" Employes is " +daily_Wage);
            Console.WriteLine("Monthly wages of {0} ", company + " Employes is " + monthly_wage);
            

        }  
    }
}
