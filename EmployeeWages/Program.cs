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
            EmployeeInfo employeeInfo = new EmployeeInfo();
            employeeInfo.Display();
            Console.ReadLine();
        }
    }
}
