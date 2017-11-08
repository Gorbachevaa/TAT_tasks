using System;

namespace Dev_13
{
    /// <summary>
    /// Class handles Middle's employee.
    /// </summary>
    class MiddleHandler : EmployeeHandler
    {
        public MiddleHandler(EmployeeHandler successor) 
        {
            this.successor = successor;
        }
        /// <summary>
        /// Creates new Employee called Middle.
        /// </summary>
        /// <param name="employeeInfo"></param>
        /// <returns> New Middle's object or Exception. </returns>
        public override Employee Handle(int priority)
        {
            try
            {
                return new Middle(priority);
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
