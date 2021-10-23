using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeInfo objEmpInfo1 = new EmployeeInfo() { EmpName = "Mahedee", EmpDesignation = "Senior Software Engineer", MonthlySalary = 00000 };
            EmployeeInfo objEmpInfo2 = new EmployeeInfo() { EmpName = "Kamal", EmpDesignation = "Software Engineer", MonthlySalary = 30000 };


            //Create a singleton object
            EmployeeService objEmployeeService = EmployeeService.Instance();
            

            objEmployeeService.AddEmployeeInfo(objEmpInfo1);
            objEmployeeService.AddEmployeeInfo(objEmpInfo2);

            Console.WriteLine(objEmpInfo2.EmpName + " : " + objEmployeeService.GetEmployeeSalaryByName("Kamal"));

            Console.ReadLine();

        }
    }
}
