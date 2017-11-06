using System;

namespace Dev_13
{
    public class Middle : Employee
    {
        public const string MIDDLE = "Middle";
        public Middle(int[] employeeInfo) : base(employeeInfo) 
        {
            Salary = 700;
            Productivity = 300;
            if (employeeInfo[0] != Salary || employeeInfo[1] != Productivity)
            {
                throw new EmployeeTypeException();
            }
        }
        public override string GetEmployeeType()
        {
            return MIDDLE;
        }
    }
}
