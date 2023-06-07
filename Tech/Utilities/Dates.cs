using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Tech.Model;

namespace Tech.Utilities
{
    public class Dates
    {



        public List<DateTime> GenerateAllThursdays(DateTime start, DateTime end)
        {

            var allThursdays = new List<DateTime>();

            var currentDate = start;
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


        public List<DateTime> GetLastThursdays(DateTime start, DateTime end)
        {
            var thursdays = GenerateAllThursdays(start, end);
            var lastThursdays = new List<DateTime>();

            foreach (var currentDate in thursdays)
            {
                var currentMonth = currentDate.Month;

                if(currentDate.AddDays(7).Month != currentMonth)
                {
                    lastThursdays.Add(currentDate);
                }

            }
            return lastThursdays;
        }

        public List<FileModel> GetNextDay (List<DateTime> thursdays, List<FileModel> data) 
        {
            var listingDays = new List<FileModel>();
            
            foreach (var day in thursdays)
            {
               var listinDay = data.Where((x, i) => i < (data.Count - 1) && x.Date > day).LastOrDefault();
                
                if (listinDay != null)
                listingDays.Add(listinDay);
            } 

            return listingDays;
        }
    }
}