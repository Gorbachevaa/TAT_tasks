using System;
using System.Text;

namespace Dev_13
{
    /// <summary>
    /// Class manager knows about every employee.
    /// </summary>
    class Manager
    {
        const int EMPLOYEESAMOUNT = 4;
        const string SPACE = " ";
        const string PRODUCTIVITY = "Maximum productivity at the fixed price: ";
        const string TEAM = "Your team is:";
        public int[][] EmployeeInfo { get; set; }
        /// <summary>
        /// Outputs suitable team.
        /// </summary>
        /// <param name="employeesAmount"></param>
        public void GetEmployees(int[] employeesAmount)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(TEAM);
            for (int i = 0; i < EMPLOYEESAMOUNT; i++)
            {
                EmployeeHandler handler = new JuniorHandler(
                   new MiddleHandler(
                   new SeniorHandler(
                   new LeadHandler(null))));
                Employee employee = handler.Handle(i);
                if (employeesAmount[i] != 0)
                {
                    sb.AppendLine(employeesAmount[i] + SPACE + employee.GetEmployeeType());
                }
            }
            Console.WriteLine(sb.ToString());
        }
        /// <summary>
        /// Gets salary of each employee.
        /// </summary>
        /// <returns>An array of employee's salary.</returns>
        public int[] GetEmployeesSalary()
        {
            EmployeeInfo = new int[EMPLOYEESAMOUNT][];
            for (int i = 0; i < EMPLOYEESAMOUNT; i++)
            {
                EmployeeHandler handler = new JuniorHandler(
                   new MiddleHandler(
                   new SeniorHandler(
                   new LeadHandler(null))));
                Employee employee = handler.Handle(i);
                EmployeeInfo[i] = employee.GetEmployeeInfo();
            }
            return new int[] { EmployeeInfo[0][0], EmployeeInfo[1][0], 
                               EmployeeInfo[2][0], EmployeeInfo[3][0] };
        }
        /// <summary>
        /// Gets each employee's productivity
        /// </summary>
        /// <returns></returns>
        public int[] GetEmployeesProductivity()
        {
            EmployeeInfo = new int[EMPLOYEESAMOUNT][];
            for (int i = 0; i < EMPLOYEESAMOUNT; i++)
            {
                EmployeeHandler handler = new JuniorHandler(
                   new MiddleHandler(
                   new SeniorHandler(
                   new LeadHandler(null))));
                Employee employee = handler.Handle(i);
                EmployeeInfo[i] = employee.GetEmployeeInfo();
            }
            return new int[] { EmployeeInfo[0][1], EmployeeInfo[1][1], 
                               EmployeeInfo[2][1], EmployeeInfo[3][1] };
        }
        /// <summary>
        /// Calculates total salaty of employees.
        /// </summary>
        /// <param name="employeesAmount"></param>
        /// <returns></returns>
        public int TotalEmployeesSalary( int[] employeesAmount)
        {
            int totalSalary = 0;
            int[] employeesSalary = GetEmployeesSalary();
            for (int i = 0; i < employeesAmount.Length; i++)
            {
                totalSalary += employeesAmount[i] * employeesSalary[i];
            }
            return totalSalary;
        }
        /// <summary>
        /// Calculates total productivity of employees.
        /// </summary>
        /// <param name="employeesAmount"></param>
        /// <returns></returns>
        public int TotalEmployeesProductivity(int[] employeesAmount)
        {
            int totalProductivity = 0;
            int[] employeesProductivity = GetEmployeesProductivity();
            for (int i = 0; i < employeesAmount.Length; i++)
            {
                totalProductivity += employeesAmount[i] * employeesProductivity[i];
            }
            return totalProductivity;
        }
       
    }
}
