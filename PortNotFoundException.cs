using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsBoats
{
    /// <summary>
    /// Класс-ошибка "Если не найдена лодка по определенному месту"
    /// </summary>
    public class PortNotFoundException : Exception
    {
        public PortNotFoundException(int i) : base("Не найдена лодка по месту " + i)
        { }
    }
}
