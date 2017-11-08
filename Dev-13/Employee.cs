using System;

namespace Dev_13
{
    /// <summary>
    /// Abstract class Employee. Has 2 methods that gets employee's salary,
    /// productivity and string type.
    /// </summary>
    abstract class Employee
    {
        public int Salary { get; set; }
        public int Productivity { get; set; }
        public int Priority { get; set; }
        public Employee() { }
        public abstract string GetEmployeeType();
        public abstract int[] GetEmployeeInfo();
    }
}
