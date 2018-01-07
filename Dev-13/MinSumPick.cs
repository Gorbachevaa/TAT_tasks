using System;

namespace Dev_13
{
    /// <summary>
    /// Picking a team with the second selection criterion.
    /// (Minimum amount of money at a fixed productivity)
    /// </summary>
    public class MinSumPick : IPickable
    {
        public int[] EmployeesAmount { get; set; }
        public int[] PickATeam(int[] customerInfo)
        {
            Manager manager = new Manager();
            int[] employeeProductivity = manager.GetEmployeesProductivity();
            int customerProductivity = customerInfo[1];
            int customerSumma = customerInfo[0];
            EmployeesAmount = new int[] { 0, 0, 0, 0 };
            while (customerProductivity > 0)
            {
                if ((customerProductivity % employeeProductivity[0]) == 0)
                {
                    EmployeesAmount[0] += (customerProductivity / employeeProductivity[0]) * 1;
                    customerProductivity -= (customerProductivity / employeeProductivity[0]) *
                        employeeProductivity[0];
                }
                else if ((customerProductivity % employeeProductivity[1]) == 0)
                {
                    EmployeesAmount[1] += (customerProductivity / employeeProductivity[1]) * 1;
                    customerProductivity -= (customerProductivity / employeeProductivity[1]) *
                        employeeProductivity[1];
                }
                else if ((customerProductivity % employeeProductivity[2]) == 0)
                {
                    EmployeesAmount[2] += (customerProductivity / employeeProductivity[2]) * 1;
                    customerProductivity -= (customerProductivity / employeeProductivity[2]) *
                        employeeProductivity[2];
                }
                else if ((customerProductivity % employeeProductivity[3]) == 0)
                {
                    EmployeesAmount[3] += (customerProductivity / employeeProductivity[3]) * 1;
                    customerProductivity -= (customerProductivity / employeeProductivity[3]) *
                        employeeProductivity[3];
                }
                if (customerProductivity >= employeeProductivity[3])
                {
                    customerProductivity -= employeeProductivity[3];
                    EmployeesAmount[3] += 1;
                }
                else if ((customerProductivity <= employeeProductivity[3]) && (customerProductivity >= employeeProductivity[2]))
                {
                    customerProductivity -= employeeProductivity[2];
                    EmployeesAmount[2] += 1;
                }
                else if ((customerProductivity <= employeeProductivity[2]) && (customerProductivity >= employeeProductivity[1]))
                {
                    customerProductivity -= employeeProductivity[1];
                    EmployeesAmount[1] += 1;
                }
                else if ((customerProductivity <= employeeProductivity[1]) && (customerProductivity >= employeeProductivity[0]))
                {
                    customerProductivity -= employeeProductivity[0];
                    EmployeesAmount[0] += 1;
                }
                if (customerProductivity < employeeProductivity[0])
                {
                    break;
                }
            }
            if (new Manager().TotalEmployeesProductivity(EmployeesAmount) == 0)
            {
                throw new CustomerProductivityException();
            }
            if (new Manager().TotalEmployeesProductivity(EmployeesAmount) != customerInfo[1])
            {
                throw new CustomerProductivityException();
            }
            if (new Manager().TotalEmployeesSalary(EmployeesAmount) > customerSumma)
            {
                throw new CustomerMoneyException();
            }
            return EmployeesAmount;
        }
    }
}
