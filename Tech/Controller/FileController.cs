using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Tech.Model;
using Tech.View;

namespace Tech.Controller
{
    public class FileController
    {
        private readonly FileModel _model;

        public FileController(FileModel model)
        {
            _model = model;
        }

     

        public List<FileModel>  ReadFileCSV ()
        {
            CultureInfo ci = new CultureInfo("es-Us");
            Console.WriteLine("Introduzca el nombre o ruta del archivo");
            var path = Console.ReadLine();
            try
            {
                using (          
                    
                    var streamReader = new StreamReader(path))
                {
                    var csvConfig = new CsvConfiguration(cultureInfo: ci)
                    {
                        Delimiter = ";"
                    };

                    using (var csvReader = new CsvReader(streamReader, csvConfig))
                    {

                        csvReader.Context.RegisterClassMap<MapController>();
                        return csvReader.GetRecords<FileModel>().ToList();

                        
                    }



                  }
                 }catch (FileNotFoundException ex) {
                        throw new FileNotFoundException(ex + "No se puede leer el archivo debido a un problema");
            }

            }
        }
            
     
    
}
