using System;

namespace Dev_13
{
    class Senior : Employee
    {
        public const string SENIOR = "Senior";
        public Senior (int i) : base()
        {
            Salary = 200;
            Productivity = 450;
            Priority = 2;
            if (i != 2)
            {
                throw new EmployeeTypeException();
            }
        }
        public override string GetEmployeeType()
        {
            return SENIOR;
        }
        public override int[] GetEmployeeInfo()
        {
            return new int[] { Salary, Productivity };
        }
    }
}
