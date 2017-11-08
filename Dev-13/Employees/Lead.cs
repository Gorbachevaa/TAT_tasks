using System;

namespace Dev_13
{
    class Lead : Employee
    {
        public const string LEAD = "Lead";
        public Lead(int i) : base() 
        {
            Salary = 300;
            Productivity = 660;
            Priority = 3;
            if (i != 3)
            {
                throw new EmployeeTypeException();
            }
        }
        public override string GetEmployeeType()
        {
            return LEAD;
        }
        public override int[] GetEmployeeInfo()
        {
            return new int[] { Salary, Productivity };
        }
    }
}
