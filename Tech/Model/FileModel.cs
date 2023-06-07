using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;

namespace Tech.Model
{
    public class FileModel
    {
       
        public  DateTime Date { get; set; }

      
        public double Cierre { get; set; }

       
        public double Apertura { get; set; }
    }
}
