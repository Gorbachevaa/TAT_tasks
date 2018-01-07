using System;

namespace Dev_13
{
    class Middle : Employee
    {
        public const string MIDDLE = "Middle";
        public Middle (int i) : base ()
        {
            Salary = 100;
            Productivity = 250;
            Priority = 1;
            if (i != 1)
            {
                throw new EmployeeTypeException();
            }
        }
        public override string GetEmployeeType()
        {
            return MIDDLE;
        }
        public override int[] GetEmployeeInfo()
        {
            return new int[] { Salary, Productivity };
        }
    }
}
