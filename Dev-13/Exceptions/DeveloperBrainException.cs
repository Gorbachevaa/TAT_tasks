using System;

namespace Dev_13
{
    class DeveloperBrainException : Exception
    {
        public DeveloperBrainException() :
            base("Here should be some variant, but a programmer didn't right it.") { }
    }
}
