using System;

namespace Dev_13
{
    public class Junior : Employee
    {
        public const string JUNIOR = "Junior";
        public Junior(int[] employeeInfo) : base(employeeInfo)
        {
            Salary = 200;
            Productivity = 100;
            if (employeeInfo[0] != Salary || employeeInfo[1] != Productivity)
            {
                throw new EmployeeTypeException();
            }
        }
        /*public override TypeOfEmployees Type()
        {
            return TypeOfEmployees.Junior;
        }*/
        public override string GetEmployeeType()
        {
            return JUNIOR;
        }
    }
}
