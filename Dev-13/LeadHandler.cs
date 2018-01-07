using System;

namespace Dev_13
{
    /// <summary>
    /// Class handles Lead's employee.
    /// </summary>
    class LeadHandler : EmployeeHandler
    {
        public LeadHandler(EmployeeHandler successor)
        {
            this.successor = successor;
        }
        /// <summary>
        /// Creates new Employee called Lead.
        /// </summary>
        /// <param name="employeeInfo"></param>
        /// <returns>New Lead's object or Exception.</returns>
        public override Employee Handle(int priority)
        {
            try
            {
                return new Lead(priority);
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
