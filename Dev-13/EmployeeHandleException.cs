using System;

namespace Dev_13
{
    /// <summary>
    /// Class inherited by Exception.  Catch exception with wrong Employee's handle.
    /// </summary>
    public class EmployeeHandleException : Exception
    {
        public EmployeeHandleException() : 
            base("There are no such employees with this salary or this productivity.") { }
    }
}
