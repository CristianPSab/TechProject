using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Tech.Model;

namespace Tech.Utilities
{
    public  class Dates
    {

      

        public List<DateTime> GenerateAllThursdays(DateTime start, DateTime end)
        {
           


            List<DateTime> allThursdays = new List<DateTime>();

            DateTime currentDate = start;
            while (currentDate <= end)
            {
                if (currentDate.DayOfWeek == DayOfWeek.Thursday)
                {
                    allThursdays.Add(currentDate);
                }
                currentDate = currentDate.AddDays(1);
            }
            return allThursdays;
        }

        public  DateTime GetLastThursdayInMonth(
          List<DateTime> latestThursdays, int month, int year, List<DateTime> allThursdays)
        {
            var lastThursday = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            while (lastThursday.DayOfWeek != DayOfWeek.Thursday)
                lastThursday = lastThursday.AddDays(-1);

            return lastThursday;
        }    
    }
}