using System;

namespace Dev_13
{
    /// <summary>
    /// Class handles Middle's employee.
    /// </summary>
    public class MiddleHandler : EmployeeHandler
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
        public override Employee Handle(int[] employeeInfo)
        {
            try
            {
                return new Middle(employeeInfo);
            }
            catch(EmployeeTypeException)
            {
                if(successor != null)
                {
                    return successor.Handle(employeeInfo);
                }
                throw new EmployeeHandleException();
            }
        }
    }
}
