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
            int Full_Day_Hours = 8;
            int Wage_Per_Day = 20;
            int Emp_Hrs = 0;
            int Wages = 0;  
            Random random = new Random();
            int attendent = random.Next(3);
            Console.WriteLine(attendent);
            if (attendent ==1 )
            {
                Emp_Hrs = 8;
                Console.WriteLine("Employee Present");

            }
            else if(attendent==2)
            {
                Emp_Hrs = 4;
                Console.WriteLine("Employee is Part_Timer");
            }
            else
            {
                Emp_Hrs = 0;
                Console.WriteLine("Employee Absent");

            }
            Wages = Emp_Hrs * Wage_Per_Day;
            Console.WriteLine("Employee Wages are : " + Wages);
           
        }
    }
}
