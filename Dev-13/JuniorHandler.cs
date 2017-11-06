using System;

namespace Dev_13
{
    /// <summary>
    /// Class handles Junior's employee.
    /// </summary>
    public class JuniorHandler : EmployeeHandler
    {
        public JuniorHandler(EmployeeHandler successor) 
        {
            this.successor = successor;
        }
        /// <summary>
        /// Creates new Employee called Junior.
        /// </summary>
        /// <param name="employeeInfo"></param>
        /// <returns> New Junior's object or Exception.</returns>
        public override Employee Handle(int[] employeeInfo)
        {
            try
            {
                return new Junior(employeeInfo);
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
