using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech.View
{
    public class View
    {
        public static void WriteNextDay(int month, int year, DateTime lastThursday)
        {
            Console.WriteLine("En la fecha " + DateTime.DaysInMonth(year, month) + "el último jueves es:" +
                lastThursday.ToShortDateString());
        }

    }
}
