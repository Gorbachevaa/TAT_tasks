using System;

namespace Dev_13
{
    /// <summary>
    /// Class handles Senior's employee.
    /// </summary>
    public class SeniorHandler : EmployeeHandler
    {
        public SeniorHandler(EmployeeHandler successor)
        {
            this.successor = successor;
        }
        /// <summary>
        /// Creates new Employee called Senior.
        /// </summary>
        /// <param name="employeeInfo"></param>
        /// <returns>New Senior's object or Exception.</returns>
        public override Employee Handle(int[] employeeInfo)
        {
            try
            {
                return new Senior(employeeInfo);
            }
            catch(EmployeeTypeException)
            {
                if (successor != null)
                {
                    return successor.Handle(employeeInfo);
                }
                throw new EmployeeHandleException();
            }
        }
    }
}
