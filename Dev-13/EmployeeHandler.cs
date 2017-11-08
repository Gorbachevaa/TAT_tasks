using System;

namespace Dev_13
{
    /// <summary>
    /// Handles all the employees.
    /// </summary>
    abstract class EmployeeHandler
    {
        protected EmployeeHandler successor;
        public abstract Employee Handle(int priority);
    }
}
