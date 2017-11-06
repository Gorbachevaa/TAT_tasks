using System;

namespace Dev_13
{
    public abstract class Employee
    {
        public int Salary { get; set; }
        public int Productivity { get; set; }
        public Employee(int[] employeeInfo) 
        {
            if ( employeeInfo[0] <= 0 && employeeInfo[1] <= 0)
            {
                throw new EmployeeHandleException();
            }
        }
        //public abstract TypeOfEmployees Type();
        public abstract string GetEmployeeType();
       // public abstract int[] GetEmployeeInfo();
    }
}
