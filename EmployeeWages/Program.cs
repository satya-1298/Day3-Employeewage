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
            Console.WriteLine("Welcome to Employee Wage Program");
            //EmployeeInfo employeeInfo = new EmployeeInfo();
            EmployeeInfo.Display("Wipro",20,8,30);
            EmployeeInfo.Display("Tata", 40, 7, 20);
            EmployeeInfo.Display("Infosys", 30, 8, 28);



            Console.ReadLine();
        }
    }
}
