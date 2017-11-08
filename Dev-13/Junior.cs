using System;

namespace Dev_13
{
    class Junior : Employee
    {
        public const string JUNIOR = "Junior";
        public Junior (int i): base()
        {
            Salary = 50;
            Productivity = 100;
            Priority = 0;
            if (i != 0)
            {
                throw new EmployeeTypeException();
            }
        }
        public override string GetEmployeeType()
        {
            return JUNIOR;
        }
        public override int[] GetEmployeeInfo()
        {
            return new int[] { Salary, Productivity };
        }
    }
}
