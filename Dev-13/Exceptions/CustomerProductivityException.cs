using System;

namespace Dev_13
{
    class CustomerProductivityException : Exception
    {
        public CustomerProductivityException() 
            : base("We don't service such productivity. Sorry!") { }
    }
}
