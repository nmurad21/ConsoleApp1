using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Exceptions
{
    class CapacityLimitException:Exception
    {
        public CapacityLimitException()
        {
        }

        public CapacityLimitException(string message) : base(message)
        {

        }
    }
}
