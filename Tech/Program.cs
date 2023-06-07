using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Tech.Controller;
using Tech.Model;
using Tech.View;
using Tech.Utilities;

namespace Tech
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
           

        }

        public void Run()
        {
            var model = new FileModel();
            var controller = new FileController(model);
            var data = controller.ReadFileCSV();
    

            var days = new Dates();
     
            DateTime start = new DateTime(2001, 5, 1);
            DateTime end = new DateTime(2017, 12, 28);


            var allThursdays = days.GetLastThursdays(start, end);

            var listingDays = days.GetNextDay(allThursdays, data);

         

            Console.ReadKey();
        }

    }
}
