using System;

namespace Dev_13
{
    class EntryPoint
    {
        const string DATAPROMPT = "Input 1 = the amount of money, \n2 = the required productivity: ";
        const string INPUTERROR = "Bad value. Please, try to enter again.";
        const string CRITERIONPROMPT = @"Input a selection criterion. 
          1 - maximum productivity at the fixed price. 
          2 - minimum summa at the fixed productivity. 
          3 - minimum amount of high qualified employees. Productivity is fixed.";
        const int CUSTOMERINFOSIZE = 2;
        static void Main(string[] args)
        {
            try
            {
                /// Input info from customer.
                Console.WriteLine(DATAPROMPT);
                int[] customerInfo = new int[CUSTOMERINFOSIZE];
                int i = 0;
                while (i < CUSTOMERINFOSIZE)
                {
                    Console.Write(i + 1 + " = ");
                    if (int.TryParse(Console.ReadLine(), out customerInfo[i]))
                    {
                        i++;
                        continue;
                    }
                    Console.WriteLine(INPUTERROR);
                }
                Console.WriteLine(CRITERIONPROMPT);
                i = 0;
                /// Input the selection criterion.
                while ( i < 1 )
                {
                    int criterionNumb;
                    if (int.TryParse(Console.ReadLine(), out criterionNumb))
                    {
                        Customer customer = new Customer(customerInfo,
                        new CriterionHandler(criterionNumb).PickTheCriterion());
                        Manager manager = new Manager();
                        manager.GetEmployees(customer.PickATeam(customerInfo));
                        i++;
                        continue;
                    }
                    throw new FormatException();
                }
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
