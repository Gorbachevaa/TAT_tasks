using System;

namespace Dev_13
{
    /// <summary>
    /// Picking a team with the third selection criterion.
    /// ( Minimum number of employees that higher than Junior. Productivity is fixed)
    /// </summary>
    public class MinHighQualifiedEmployeesPick : IPickable
    {
        public const int EMPLOYEES = 4;
        public int[] EmployeesAmount { get; set; }
        public int[] PickATeam(int[] customerInfo)
        {
            Manager manager = new Manager();
            int[] employeeProductivity = manager.GetEmployeesProductivity();
            int customerProductivity = customerInfo[1];
            int customerSumma = customerInfo[0];
            EmployeesAmount = new int[] { 0, 0, 0, 0 };
            int maxJun = customerProductivity / employeeProductivity[0];
            EmployeesAmount[0] += maxJun;
            while (customerProductivity > 0 )
            {
                if (manager.TotalEmployeesProductivity(EmployeesAmount) == customerProductivity)
                {
                    customerProductivity -= manager.TotalEmployeesProductivity(EmployeesAmount);
                }
                if (new Manager().TotalEmployeesSalary(EmployeesAmount) > customerSumma)
                {
                    throw new CustomerMoneyException();
                }
                if (new Manager().TotalEmployeesProductivity(EmployeesAmount) != customerInfo[1])
                {
                    throw new DeveloperBrainException();
                }
            }
            return EmployeesAmount;
        }
    }
}
