using System;

namespace Dev_13
{
    public class Senior : Employee
    {
        public const string SENIOR = "Senior";
        public Senior(int[] employeeInfo) : base(employeeInfo) 
        {
            Salary = 1000;
            Productivity = 500;
            if (employeeInfo[0] != Salary || employeeInfo[1] != Productivity)
            {
                throw new EmployeeTypeException();
            }
        }
        public override string GetEmployeeType()
        {
            return SENIOR;
        }
    }
}
