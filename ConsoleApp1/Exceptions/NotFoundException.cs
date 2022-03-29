using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Exceptions
{
    class NotFoundException:Exception
    {
        public NotFoundException()
        {
        }
        public NotFoundException(string message) : base(message)
        {

        }
    }
}
