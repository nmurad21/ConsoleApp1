using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Exceptions
{
    class MedicineAlreadyExistsException:Exception
    {
        public MedicineAlreadyExistsException()
        {
        }

        public MedicineAlreadyExistsException(string message) : base(message)
        {

        }
    }
}
