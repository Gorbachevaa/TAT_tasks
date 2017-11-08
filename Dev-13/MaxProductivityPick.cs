using System;

namespace Dev_13
{
    /// <summary>
    /// Picking a team with the first selection criterion.
    /// (Maximum productivity at a fixed price)
    /// </summary>
    public class MaxProductivityPick : IPickable
    {
        public const int EMPLOYEES = 4;

        public int[] EmployeesAmount { get; set; }
        public int[] PickATeam(int[] customerInfo)
        {
            Manager manager = new Manager();
            int[] employeeSalary = manager.GetEmployeesSalary();
            int customerSumma = customerInfo[0];
            EmployeesAmount = new int[] { 0, 0, 0, 0 };
            while (customerSumma > 0)
            {
                if (customerSumma >= employeeSalary[3])
                {
                    customerSumma -= employeeSalary[3];
                    EmployeesAmount[3] += 1;
                }
                else if ((customerSumma <= employeeSalary[3]) && (customerSumma >= employeeSalary[2]))
                {
                    customerSumma -= employeeSalary[2];
                    EmployeesAmount[2] += 1;
                }
                else if ((customerSumma <= employeeSalary[2]) && (customerSumma >= employeeSalary[1]))
                {
                    customerSumma -= employeeSalary[1];
                    EmployeesAmount[1] += 1;
                }
                else if ((customerSumma <= employeeSalary[1]) && (customerSumma >= employeeSalary[0]))
                {
                    customerSumma -= employeeSalary[0];
                    EmployeesAmount[0] += 1;
                }
                if (customerSumma < employeeSalary[0])
                {
                    break;
                }
            }
            if (new Manager().TotalEmployeesSalary(EmployeesAmount) == 0)
            {
                throw new CustomerMoneyException();
            }
            return EmployeesAmount;
        }
    }
}
