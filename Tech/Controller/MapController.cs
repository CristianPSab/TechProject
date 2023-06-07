using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tech.Model;

namespace Tech.Controller
{
    public class MapController  : ClassMap<FileModel>
    {
        public MapController() 
        {
           
            Map(m => m.Date).Name("Fecha");
            Map(m => m.Cierre).Name("Cierre");
            Map(m => m.Apertura).Name("Apertura");
        }
    }
}
