using System;

namespace Dev_13
{
    /// <summary>
    /// Class handles Junior's employee.
    /// </summary>
    class JuniorHandler : EmployeeHandler
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
        public override Employee Handle(int priority)
        {
            try
            {
                return new Junior(priority);
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
