using System;

namespace Dev_13
{
    enum TypeOfEmployees
    {
        Junior,
        Middle,
        Senior,
        Lead
    }
    class EntryPoint
    {
        const string DATAPROMPT = "Input 1 = the amount of money, \n2 = the required productivity: ";
        const string INPUTERROR = "Bad value. Please, try to enter again.";
        const int CUSTOMERSINFOSIZE = 2;
        static void Main(string[] args)
        {
            try
            {
                /// Input info from customer.
                Console.WriteLine(DATAPROMPT);
                int[] customerInfo = new int[CUSTOMERSINFOSIZE];
                int i = 0;
                while (i < CUSTOMERSINFOSIZE)
                {
                    Console.Write(i + 1 + " = ");
                    if (int.TryParse(Console.ReadLine(), out customerInfo[i]))
                    {
                        i++;
                        continue;
                    }
                    Console.WriteLine(INPUTERROR);
                }
                EmployeeHandler handler = new JuniorHandler(
                    new MiddleHandler(
                    new SeniorHandler(
                    new LeadHandler(null))));
                Employee employee = handler.Handle(customerInfo);
                Console.WriteLine(employee.GetEmployeeType());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
