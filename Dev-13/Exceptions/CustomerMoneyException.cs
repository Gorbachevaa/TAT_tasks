using System;

namespace Dev_13
{
    /// <summary>
    /// Class inherited by Exception.  Catch exception when there are not enough customer's money.
    /// </summary>
    class CustomerMoneyException : Exception
    {
        public CustomerMoneyException() : 
            base("You have not enough money. We can't help you.") { }

    }
}
