using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    /// <summary>
    /// EmployeeService is a singleton class
    /// </summary>
    public class EmployeeService
    {

        //Static object of singleton class
        private static EmployeeService instance;

        private List<EmployeeInfo> lstEmployeeInfo = null;

        /// <summary>
        /// Restrict to create object of Singleton class
        /// </summary>
        private EmployeeService()
        {
            if (lstEmployeeInfo == null)
            {
                lstEmployeeInfo = new List<EmployeeInfo>();
            }
        }


        /// <summary>
        /// The static method to provide global access to the singleton object.
        /// </summary>
        /// <returns>Singleton object of EmployeeService class</returns>
        public static EmployeeService Instance()
        {
            
            if (instance == null)
            {
                //Thread safe singleton

                lock (typeof(EmployeeService))
                {
                    instance = new EmployeeService();
                }
            }

            return instance;
        }


        /// <summary>
        /// Add employee information to the Employee information list
        /// </summary>
        /// <param name="objEmployeeInfo"></param>
        public void AddEmployeeInfo(EmployeeInfo objEmployeeInfo)
        {
            lstEmployeeInfo.Add(objEmployeeInfo);
        }


        /// <summary>
        /// Get Salary by Name
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Salary of Employee</returns>
        public int GetEmployeeSalaryByName(string name)
        {
            int monthlySalary = 0;
            foreach (EmployeeInfo objEmployeeInfo in lstEmployeeInfo)
            {
                if (objEmployeeInfo.EmpName.Contains(name))
                    monthlySalary = objEmployeeInfo.MonthlySalary;
            }
            return monthlySalary;
        }

    }
}
