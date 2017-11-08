using System;

namespace Dev_13
{
    /// <summary>
    /// Class handles Senior's employee.
    /// </summary>
    class SeniorHandler : EmployeeHandler
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
        public override Employee Handle(int priority)
        {
            try
            {
                return new Senior(priority);
            }
            catch (EmployeeTypeException)
            {
                if (successor != null)
                {
                    return successor.Handle(priority);
                }
                throw new EmployeeHandleException();
            }
        }
    }
}
