using System;

namespace Dev_13
{
    public class Lead : Employee
    {
        public const string LEAD = "Lead";
        public Lead(int[] employeeInfo) : base(employeeInfo) 
        {
            Salary = 1500;
            Productivity = 800;
            if( employeeInfo[0] != Salary || employeeInfo[1] != Productivity )
            {
                throw new EmployeeTypeException();
            }
        }
        public override string GetEmployeeType()
        {
            return LEAD;
        }
    }
}
