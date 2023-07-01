using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //int emp_Hours = 0;

            Console.WriteLine("Welcome to Employee Wage Program");
            EmployeeInfo employeeInfo = new EmployeeInfo("Wipro", 20, 30,8,8,4);
            EmployeeInfo employeeInfo_one = new EmployeeInfo("Infosys", 30, 28,9,8,5);
            EmployeeInfo employeeInfo_two = new EmployeeInfo("TATA", 20, 30,8,9,5);
            employeeInfo.calculateWage();
            Console.WriteLine(employeeInfo.SaveWage());
            employeeInfo_one.calculateWage(); 
            Console.WriteLine(employeeInfo_one.SaveWage());
            employeeInfo_two.calculateWage();
            Console.WriteLine(employeeInfo_two.SaveWage());
            Console.ReadLine();
        }
    }
}
