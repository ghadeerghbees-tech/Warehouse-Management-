using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Warehouse_Management__
{
   public sealed 
        
        
        
        class FileManager
    {
        public static List<T> LoadFormFile<T>(string fileName)
        {
            if (!File.Exists(fileName))
             return new List<T>();
            string json = File.ReadAllText(fileName);
            return JsonConvert.DeserializeObject<List<T>>(json);

        }

        public static void SaveToFile<T>(List<T> data ,string fileName)
        {
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(fileName, json);
        }
    }
}
