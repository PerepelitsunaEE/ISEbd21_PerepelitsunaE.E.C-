using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsBoats
{
    /// <summary>
    /// Класс-ошибка "Если в гавани уже заняты все места"
    /// </summary>
    public class PortOverflowException : Exception
    {
        public PortOverflowException() : base("В гавани нет свободных мест")
        { }
    }
}
