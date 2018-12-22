using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsBoats
{
    public class PortAlreadyHaveException : Exception
    {
        public PortAlreadyHaveException() : base("Уже есть такая лодка")
        { }
    }
}
 